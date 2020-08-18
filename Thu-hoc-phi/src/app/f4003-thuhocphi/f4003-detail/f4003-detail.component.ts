import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { NgxPrintModule } from 'ngx-print';


@Component({
  selector: 'app-f4003-detail',
  templateUrl: './f4003-detail.component.html',
  styleUrls: ['./f4003-detail.component.scss']
})
export class F4003DetailComponent implements OnInit {

  id: any;
  data: any;
  detail1 = [];
  detail = [];

  private apiUrl = 'https://localhost:44393/api/ThuHocPhis';
  private apiUrl1 = 'https://localhost:44393/api/HocSinhs';
  private apiUrl2 = 'https://localhost:44393/api/Lops';
  private apiUrl3 = 'https://localhost:44393/api/HinhThucThus';
  private apiUrl4 = 'https://localhost:44393/api/KhoanThuCoDinhs';
  private apiUrl5 = 'https://localhost:44393/api/KhoanThuDichVus';
  private apiUrl6 = 'https://localhost:44393/api/KhoanThuBanHangs';
  private apiUrl7 = 'https://localhost:44393/api/KhoanChiMienGiams';

  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = []; ItemsArray3 = []; ItemsArray4 = [];
  ItemsArray5 = []; ItemsArray6 = []; ItemsArray7 = [];
  constructor(private http: HttpClient, private route: ActivatedRoute) { }

  ngOnInit(): void {
    // tslint:disable-next-line: no-string-literal
    this.id = this.route.snapshot.params['id'];
    this.getDatas1().subscribe((data: any[]) => {
      this.ItemsArray1 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray1.length; i++){
        // tslint:disable-next-line: radix
        if (this.ItemsArray1[i].id === parseInt(this.id)) {
          this.detail1.push(this.ItemsArray1[i]);
        }
      }
    });
    this.getDatas().subscribe((data: any[]) => {
      this.ItemsArray = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++){
        // tslint:disable-next-line: radix
        if (this.ItemsArray[i].idHocSinh === parseInt(this.id)) {
          this.detail.push(this.ItemsArray[i]);
        }
      }
    });
    this.getDatas2().subscribe((data: any[]) => {
      this.ItemsArray2 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray2.length; i++){
        if (this.detail1[0].idLop === this.ItemsArray2[i].id) {
          this.detail1[0].tenLop = this.ItemsArray2[i].tenLop;
        }
      }
      console.log(this.detail1[0].idLop);
    });
    this.getDatas3().subscribe((data: any[]) => {
      this.ItemsArray3 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray3.length; i++){
        if (this.detail[0].idHinhThucThu === this.ItemsArray3[i].id) {
          this.detail[0].tenHinhThucThu = this.ItemsArray3[i].tenHinhThucThu;
        }
      }
      console.log(this.detail);
    });

    // Thanh Tien
    this.getDatas4().subscribe((data: any[]) => {
      this.ItemsArray4 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detail.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray4.length; j++ ){
          if (this.detail[i].idKhoanThuCoDinh === this.ItemsArray4[j].id){
            this.detail[i].tenKhoanThuCoDinh = this.ItemsArray4[j].tenKhoanThuCoDinh;
            this.detail[i].donGia1 = this.ItemsArray4[j].donGia;
          }
        }
      }
      this.data = this.detail[0].tenHinhThucThu;
      console.log(this.detail[0].idHinhThucThu);
    });
    this.getDatas5().subscribe((data: any[]) => {
      this.ItemsArray5 = data;
      for (let i = 0; i < this.detail.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray5.length; j++ ){
          if (this.ItemsArray[i].idKhoanThuDichVu === this.ItemsArray5[j].id){
            this.detail[i].tenKhoanThuDichVu = this.ItemsArray5[j].tenKhoanThuDichVu;
            this.detail[i].donGia2 = this.ItemsArray5[j].donGia;
          }
        }
      }
    });
    this.getDatas6().subscribe((data: any[]) => {
      this.ItemsArray6 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detail.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray6.length; j++ ){
          if (this.detail[i].idKhoanThuBanHang === this.ItemsArray6[j].id){
            this.detail[i].tenKhoanThuBanHang = this.ItemsArray6[j].tenSanPham;
            this.detail[i].donGia3 = this.ItemsArray6[j].donGia;
          }
        }
      }
    });
    // Khau Tru
    this.getDatas7().subscribe((data: any[]) => {
      this.ItemsArray7 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detail.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray7.length; j++ ){
          if (this.detail[i].idKhoanChiMienGiam === this.ItemsArray7[j].id){
            this.detail[i].khauTru = this.ItemsArray7[j].soTienMienGiam;
          }
        }
      }
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detail.length; i++) {
        // tslint:disable-next-line: max-line-length
        this.detail[i].thanhTien = ((this.detail[i].donGia1 * this.detail[i].soLuong1) + (this.detail[i].donGia2 * this.detail[i].soLuong2) + (this.detail[i].donGia3 * this.detail[i].soLuong3));
        console.log(this.detail[i].thanhTien);
      }
    });
  }

  // tslint:disable-next-line: typedef
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  getDatas3(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl3); }
  getDatas4(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl4); }
  getDatas5(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl5); }
  getDatas6(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl6); }
  getDatas7(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl7); }

  // tslint:disable-next-line: typedef
  getTotalCost() { return this.detail.map(t => t.thanhTien).reduce((acc, value) => acc + value, 0); }
  // tslint:disable-next-line: typedef
  getTotalReduce() { return this.detail.map(t => t.khauTru).reduce((acc, value) => acc + value, 0); }
  // tslint:disable-next-line: typedef
  getMustPay() { return this.getTotalCost() - this.getTotalReduce(); }
}
