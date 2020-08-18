import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f2001-add',
  templateUrl: './f2001-add.component.html',
  styleUrls: ['./f2001-add.component.scss']
})
export class F2001AddComponent implements OnInit {

  addForm: FormGroup;
  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = [];

  private apiUrl0 = 'https://localhost:44393/api/DangKyDichVus';
  private apiUrl = 'https://localhost:44393/api/DotThus';
  private apiUrl1 = 'https://localhost:44393/api/KhoanThuDichVus';
  private apiUrl2 = 'https://localhost:44393/api/HocSinhs';
  constructor(private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    this.getDatas().subscribe((data: any[]) => { this.ItemsArray = data; });
    this.getDatas1().subscribe((data: any[]) => { this.ItemsArray1 = data; });
    this.getDatas2().subscribe((data: any[]) => { this.ItemsArray2 = data; });
    this.reactiveForm();
  }
  onSubmit(): void {
    this.http.post<any>(this.apiUrl0, this.addForm.value).subscribe(
      (data: any) => {
        alert('Post method is succeed!');
        this.document.location.href = 'http://localhost:4200/quanlydangkydichvu';
      },
      error => { alert('Post method is failed!'); }
    );
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.addForm = this.builder.group({
      DonViTinh: ['', [Validators.required]],
      SoLuong: ['', [Validators.required]],
      IdDotThu: ['', [Validators.required]],
      IdHocSinh: ['', [Validators.required]],
      IdKhoanThuDichVu: ['', [Validators.required]],
      GhiChu: ['', ]
    });
  }

  get DonViTinh(): any { return this.addForm.get('DonViTinh'); }
  get SoLuong(): any { return this.addForm.get('SoLuong'); }
  get IdDotThu(): any { return this.addForm.get('IdDotThu'); }
  get IdHocSinh(): any { return this.addForm.get('IdHocSinh'); }
  get IdKhoanThuDichVu(): any { return this.addForm.get('IdKhoanThuDichVu'); }
  get GhiChu(): any { return this.addForm.get('GhiChu'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.addForm.controls[control].hasError(error); };
}
