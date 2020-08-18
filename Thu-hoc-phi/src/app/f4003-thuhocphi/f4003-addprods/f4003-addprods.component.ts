import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormControl, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f4003-addprods',
  templateUrl: './f4003-addprods.component.html',
  styleUrls: ['./f4003-addprods.component.scss']
})
export class F4003AddprodsComponent implements OnInit {

  date = new Date();
  addForm: FormGroup;
  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = []; ItemsArray3 = []; ItemsArray4 = [];
  ItemsArray5 = []; ItemsArray6 = []; ItemsArray7 = []; ItemsArray8 = []; ItemsArray9 = [];
  ThuHocPhi = []; NguoiThu = []; KhoanChiMienGiam = []; HocSinh = []; Lop = [];
  KhoanThuCoDinh = []; KhoanThuDichVu = []; KhoanThuBanHang = []; HinhThucThu = []; HocKy = [];

  private apiUrl = 'https://localhost:44393/api/ThuHocPhis';
  private apiUrl1 = 'https://localhost:44393/api/NguoiThus';
  private apiUrl2 = 'https://localhost:44393/api/KhoanChiMienGiams';
  private apiUrl3 = 'https://localhost:44393/api/KhoanThuCoDinhs';
  private apiUrl4 = 'https://localhost:44393/api/KhoanThuDichVus';
  private apiUrl5 = 'https://localhost:44393/api/KhoanThuBanHangs';
  private apiUrl6 = 'https://localhost:44393/api/HocSinhs';
  private apiUrl7 = 'https://localhost:44393/api/HinhThucThus';
  private apiUrl8 = 'https://localhost:44393/api/HocKies';
  private apiUrl9 = 'https://localhost:44393/api/Lops';
  constructor(private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    // tslint:disable-next-line: align
    this.getDatas().subscribe((data: any[]) => {
      this.ItemsArray = data;
      this.ThuHocPhi = this.ItemsArray;
    });
    this.getDatas1().subscribe((data: any[]) => {
      this.ItemsArray1 = data;
      this.NguoiThu = this.ItemsArray1;
    });
    this.getDatas2().subscribe((data: any[]) => {
      this.ItemsArray2 = data;
      this.KhoanChiMienGiam = this.ItemsArray2;
    });
    this.getDatas3().subscribe((data: any[]) => {
      this.ItemsArray3 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray3.length; i++ ){
        if (this.ItemsArray3[i].suDung === true){
          this.KhoanThuCoDinh.push(this.ItemsArray3[i]);
        }
      }
    });
    this.getDatas4().subscribe((data: any[]) => {
      this.ItemsArray4 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray4.length; i++ ){
        if (this.ItemsArray4[i].suDung === true){
          this.KhoanThuDichVu.push(this.ItemsArray4[i]);
        }
      }
    });
    this.getDatas5().subscribe((data: any[]) => {
      this.ItemsArray5 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray5.length; i++ ){
        if (this.ItemsArray5[i].suDung === true){
          this.KhoanThuBanHang.push(this.ItemsArray5[i]);
        }
      }
    });
    this.getDatas6().subscribe((data: any[]) => {
      this.ItemsArray6 = data;
      this.HocSinh = this.ItemsArray6;
    });
    this.getDatas7().subscribe((data: any[]) => {
      this.ItemsArray7 = data;
      this.HinhThucThu = this.ItemsArray7;
    });
    this.getDatas8().subscribe((data: any[]) => {
      this.ItemsArray8 = data;
      this.HocKy = this.ItemsArray8;
    });
    this.getDatas9().subscribe((data: any[]) => {
      this.ItemsArray9 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray6.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray9.length; j++ ){
          if (this.ItemsArray6[i].idLop === this.ItemsArray9[j].id){
            this.HocSinh[i].tenLop = this.ItemsArray9[j].tenLop;
          }
        }
      }
    });
    this.reactiveForm();
  }
  onSubmit(): void {
    this.http.post<any>(this.apiUrl, this.addForm.value).subscribe(
      (data: any) => {
        alert('Post method is succeed!');
        this.document.location.href = 'http://localhost:4200/thuhocphi';
      },
      error => { alert('Post method is failed!'); }
    );
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  getDatas3(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl3); }
  getDatas4(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl4); }
  getDatas5(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl5); }
  getDatas6(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl6); }
  getDatas7(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl7); }
  getDatas8(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl8); }
  getDatas9(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl9); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.addForm = this.builder.group({
      NgayThu: [this.date, ],
      IdHocKy: ['', [Validators.required]],
      IdKhoanChiMienGiam: ['', [Validators.required]],
      IdHocSinh: ['', [Validators.required]],
      IdNguoiThu: ['', [Validators.required]],
      IdHinhThucThu: ['', [Validators.required]],
      IdKhoanThuCoDinh: ['', [Validators.required]],
      SoLuong1: ['', [Validators.required]],
      IdKhoanThuDichVu: ['', [Validators.required]],
      SoLuong2: ['', [Validators.required]],
      IdKhoanThuBanHang: ['', [Validators.required]],
      SoLuong3: ['', [Validators.required]]
    });
  }

  get NgayThu(): any { return this.addForm.get('NgayThu'); }
  get IdHocKy(): any { return this.addForm.get('IdHocKy'); }
  get IdKhoanChiMienGiam(): any { return this.addForm.get('IdKhoanChiMienGiam'); }
  get IdHocSinh(): any { return this.addForm.get('IdHocSinh'); }
  get IdNguoiThu(): any { return this.addForm.get('IdNguoiThu'); }
  get IdHinhThucThu(): any { return this.addForm.get('IdHinhThucThu'); }
  get IdKhoanThuCoDinh(): any { return this.addForm.get('IdKhoanThuCoDinh'); }
  get SoLuong1(): any { return this.addForm.get('SoLuong1'); }
  get IdKhoanThuDichVu(): any { return this.addForm.get('IdKhoanThuDichVu'); }
  get SoLuong2(): any { return this.addForm.get('SoLuong2'); }
  get IdKhoanThuBanHang(): any { return this.addForm.get('IdKhoanThuBanHang'); }
  get SoLuong3(): any { return this.addForm.get('SoLuong3'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.addForm.controls[control].hasError(error); };

}
