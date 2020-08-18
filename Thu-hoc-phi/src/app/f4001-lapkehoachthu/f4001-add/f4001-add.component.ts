import { Component, OnInit, ViewChild, Inject } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f4001-add',
  templateUrl: './f4001-add.component.html',
  styleUrls: ['./f4001-add.component.scss']
})
export class F4001AddComponent implements OnInit {

  addForm: FormGroup;
  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = []; ItemsArray3 = [];
  displayedColumns: string[] = [ 'id', 'ten', 'sotien', 'ghichu'];

  private apiUrl0 = 'https://localhost:44393/api/KeHoachThus';
  private apiUrl = 'https://localhost:44393/api/KhoanThuCoDinhs';
  private apiUrl1 = 'https://localhost:44393/api/HinhThucThus';
  private apiUrl2 = 'https://localhost:44393/api/HocKies';
  private apiUrl3 = 'https://localhost:44393/api/Khois';
  dataSource = new MatTableDataSource<any>();
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  constructor(private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
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
  onSubmit(): void {
    this.http.post<any>(this.apiUrl0, this.addForm.value).subscribe(
      (data: any) => {
        alert('Post method is succeed!');
        this.document.location.href = 'http://localhost:4200/lapkehoachthu';
      },
      error => { alert('Post method is failed!'); }
    );
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  getDatas3(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl3); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.addForm = this.builder.group({
      SoLuongHocSinh: ['', [Validators.required]],
      BatBuoc: ['true', ],
      IdHocKy: ['', [Validators.required]],
      IdKhoi: ['', [Validators.required]],
      IdHinhThucThu: ['', [Validators.required]],
      IdKhoanThuCoDinh: ['', [Validators.required]],
      GhiChu: ['', ]
    });
  }

  get SoLuongHocSinh(): any { return this.addForm.get('SoLuongHocSinh'); }
  get BatBuoc(): any { return this.addForm.get('BatBuoc'); }
  get IdHocKy(): any { return this.addForm.get('IdHocKy'); }
  get IdKhoi(): any { return this.addForm.get('IdKhoi'); }
  get IdHinhThucThu(): any { return this.addForm.get('IdHinhThucThu'); }
  get IdKhoanThuCoDinh(): any { return this.addForm.get('IdKhoanThuCoDinh'); }
  get GhiChu(): any { return this.addForm.get('GhiChu'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.addForm.controls[control].hasError(error); };
}
