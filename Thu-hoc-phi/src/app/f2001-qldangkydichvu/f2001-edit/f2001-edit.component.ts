import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { Validators, FormBuilder, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f2001-edit',
  templateUrl: './f2001-edit.component.html',
  styleUrls: ['./f2001-edit.component.scss']
})
export class F2001EditComponent implements OnInit {

  Id: number;
  editForm: FormGroup;
  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = [];

  private apiUrl0 = 'https://localhost:44393/api/DangKyDichVus';
  private apiUrl = 'https://localhost:44393/api/DotThus';
  private apiUrl1 = 'https://localhost:44393/api/KhoanThuDichVus';
  private apiUrl2 = 'https://localhost:44393/api/HocSinhs';
  // tslint:disable-next-line: max-line-length
  constructor(private route: ActivatedRoute, private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    // tslint:disable-next-line: no-string-literal
    this.Id = this.route.snapshot.params['id'];
    this.getDatas().subscribe((data: any[]) => { this.ItemsArray = data; });
    this.getDatas1().subscribe((data: any[]) => { this.ItemsArray1 = data; });
    this.getDatas2().subscribe((data: any[]) => { this.ItemsArray2 = data; });
    this.reactiveForm();
  }
  onSubmit(id: any): void{
    this.http.put<any>(this.apiUrl0 + `/${id}`, this.editForm.value).subscribe(
      (data: any) => {
        alert('Put method is succeed!');
        this.document.location.href = 'http://localhost:4200/quanlydangkydichvu';
      },
      error => { alert('Put method is failed!'); }
    );
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.editForm = this.builder.group({
      Id: [this.Id, ],
      DonViTinh: ['', [Validators.required]],
      SoLuong: ['', [Validators.required]],
      IdDotThu: ['', [Validators.required]],
      IdHocSinh: ['', [Validators.required]],
      IdKhoanThuDichVu: ['', [Validators.required]],
      GhiChu: ['', ]
    });
  }

  get DonViTinh(): any { return this.editForm.get('DonViTinh'); }
  get SoLuong(): any { return this.editForm.get('SoLuong'); }
  get IdDotThu(): any { return this.editForm.get('IdDotThu'); }
  get IdHocSinh(): any { return this.editForm.get('IdHocSinh'); }
  get IdKhoanThuDichVu(): any { return this.editForm.get('IdKhoanThuDichVu'); }
  get GhiChu(): any { return this.editForm.get('GhiChu'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.editForm.controls[control].hasError(error); };
}
