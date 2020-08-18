import { Component, OnInit, ViewChild, Inject } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { Validators, FormBuilder, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f4001-edit',
  templateUrl: './f4001-edit.component.html',
  styleUrls: ['./f4001-edit.component.scss']
})
export class F4001EditComponent implements OnInit {

  Id: number;
  editForm: FormGroup;
  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = []; ItemsArray3 = [];
  displayedColumns: string[] = [ 'id', 'ten', 'sotien', 'ghichu'];

  private apiUrl0 = 'https://localhost:44393/api/KeHoachThus';
  private apiUrl = 'https://localhost:44393/api/KhoanThuCoDinhs';
  private apiUrl1 = 'https://localhost:44393/api/HinhThucThus';
  private apiUrl2 = 'https://localhost:44393/api/HocKies';
  private apiUrl3 = 'https://localhost:44393/api/Khois';
  dataSource = new MatTableDataSource<any>();
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  constructor(private route: ActivatedRoute, private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    // tslint:disable-next-line: no-string-literal
    this.Id = this.route.snapshot.params['id'];
    this.dataSource.paginator = this.paginator;
    // tslint:disable-next-line: align
    this.getDatas().subscribe((data: any[]) => {
      this.ItemsArray = data;
      this.dataSource.data = this.ItemsArray;
    });
    this.getDatas1().subscribe((data: any[]) => { this.ItemsArray1 = data; });
    this.getDatas2().subscribe((data: any[]) => { this.ItemsArray2 = data; });
    this.getDatas3().subscribe((data: any[]) => { this.ItemsArray3 = data; });
    this.reactiveForm();
  }
  onSubmit(id: any): void{
    this.http.put<any>(this.apiUrl0 + `/${id}`, this.editForm.value).subscribe(
      (data: any) => {
        alert('Put method is succeed!');
        this.document.location.href = 'http://localhost:4200/lapkehoachthu';
      },
      error => { alert('Put method is failed!'); }
    );
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  getDatas3(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl3); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.editForm = this.builder.group({
      Id: [this.Id, ],
      SoLuongHocSinh: ['', [Validators.required]],
      BatBuoc: ['true', ],
      IdHocKy: ['', [Validators.required]],
      IdKhoi: ['', [Validators.required]],
      IdHinhThucThu: ['', [Validators.required]],
      IdKhoanThuCoDinh: ['', [Validators.required]],
      GhiChu: ['', ]
    });
  }

  get SoLuongHocSinh(): any { return this.editForm.get('SoLuongHocSinh'); }
  get BatBuoc(): any { return this.editForm.get('BatBuoc'); }
  get IdHocKy(): any { return this.editForm.get('IdHocKy'); }
  get IdKhoi(): any { return this.editForm.get('IdKhoi'); }
  get IdHinhThucThu(): any { return this.editForm.get('IdHinhThucThu'); }
  get IdKhoanThuCoDinh(): any { return this.editForm.get('IdKhoanThuCoDinh'); }
  get GhiChu(): any { return this.editForm.get('GhiChu'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.editForm.controls[control].hasError(error); };
}
