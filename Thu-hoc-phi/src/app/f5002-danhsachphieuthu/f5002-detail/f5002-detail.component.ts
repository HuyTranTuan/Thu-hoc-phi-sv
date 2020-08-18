import { Component, OnInit } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-f5002-detail',
  templateUrl: './f5002-detail.component.html',
  styleUrls: ['./f5002-detail.component.scss']
})
export class F5002DetailComponent implements OnInit {
  a: any;
  id: any;
  filter: boolean;
  detailHocSinh = [];
  detailThuHocPhi = [];
  test = [];
  dataSource = new MatTableDataSource<any>();
  displayedColumns1: string[] = ['id', 'tenkhoanthucodinh', 'soluong1', 'tenkhoanthudichvu', 'soluong2', 'tenKhoanthubanhang', 'soluong3', 'hinhthucthu', 'thanhtien'];
  displayedColumns2: string[] = ['id', 'tenkhoanchimiengiam', 'sotienmiengiam'];

  private apiUrl = 'https://localhost:44393/api/ThuHocPhis';
  private apiUrl1 = 'https://localhost:44393/api/HocSinhs';
  private apiUrl2 = 'https://localhost:44393/api/Lops';
  private apiUrl3 = 'https://localhost:44393/api/HinhThucThus';
  private apiUrl4 = 'https://localhost:44393/api/KhoanThuCoDinhs';
  private apiUrl5 = 'https://localhost:44393/api/KhoanThuDichVus';
  private apiUrl6 = 'https://localhost:44393/api/KhoanThuBanHangs';
  private apiUrl7 = 'https://localhost:44393/api/KhoanChiMienGiams';
  ThuHocPhi = []; HocSinh = []; Lop = []; HinhThucThu = []; KhoanThuCoDinh = [];
  KhoanThuDichVu = []; KhoanThuBanHang = []; KhoanChiMienGiam = [];
  constructor(private http: HttpClient, private route: ActivatedRoute) { }

  ngOnInit(): void {
    // tslint:disable-next-line: no-string-literal
    this.id = this.route.snapshot.params['id'];
    this.getDatas1().subscribe((data: any[]) => {
      this.HocSinh = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.HocSinh.length; i++){
        // tslint:disable-next-line: radix
        if (this.HocSinh[i].id === parseInt(this.id)) {
          this.detailHocSinh.push(this.HocSinh[i]);
        }
      }
    });
    this.getDatas().subscribe((data: any[]) => {
      this.ThuHocPhi = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++){
        // tslint:disable-next-line: radix
        if (this.ThuHocPhi[i].idHocSinh === parseInt(this.id)) {
          this.detailThuHocPhi.push(this.ThuHocPhi[i]);
        }
      }
      console.log(this.detailThuHocPhi);
      console.log(this.ThuHocPhi);
      // this.dataSource.data = this.detailThuHocPhi;
    });
    this.getDatas2().subscribe((data: any[]) => {
      this.Lop = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detailHocSinh.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.Lop.length; j++){
          if (this.detailHocSinh[i].idLop === this.Lop[j].id) {
            this.detailHocSinh[i].tenLop = this.Lop[j].tenLop;
          }
        }
      }
    });
    this.getDatas3().subscribe((data: any[]) => {
      this.HinhThucThu = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detailThuHocPhi.length; i++){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.HinhThucThu.length; j++) {
          if (this.detailThuHocPhi[i].idHinhThucThu === this.HinhThucThu[j].id) {
            this.detailThuHocPhi[i].tenHinhThucThu = this.HinhThucThu[j].tenHinhThucThu;
          }
        }
      }
    });

    // Thanh Tien
    this.getDatas4().subscribe((data: any[]) => {
      this.KhoanThuCoDinh = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detailThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.KhoanThuCoDinh.length; j++ ){
          if (this.detailThuHocPhi[i].idKhoanThuCoDinh === this.KhoanThuCoDinh[j].id){
            this.detailThuHocPhi[i].tenKhoanThuCoDinh = this.KhoanThuCoDinh[j].tenKhoanThuCoDinh;
            this.detailThuHocPhi[i].donGia1 = this.KhoanThuCoDinh[j].donGia;
          }
        }
      }
    });
    this.getDatas5().subscribe((data: any[]) => {
      this.KhoanThuDichVu = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detailThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.KhoanThuDichVu.length; j++ ){
          if (this.detailThuHocPhi[i].idKhoanThuDichVu === this.KhoanThuDichVu[j].id){
            this.detailThuHocPhi[i].tenKhoanThuDichVu = this.KhoanThuDichVu[j].tenKhoanThuDichVu;
            this.detailThuHocPhi[i].donGia2 = this.KhoanThuDichVu[j].donGia;
          }
        }
      }
    });
    this.getDatas6().subscribe((data: any[]) => {
      this.KhoanThuBanHang = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detailThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.KhoanThuBanHang.length; j++ ){
          if (this.detailThuHocPhi[i].idKhoanThuBanHang === this.KhoanThuBanHang[j].id){
            this.detailThuHocPhi[i].tenKhoanThuBanHang = this.KhoanThuBanHang[j].tenSanPham;
            this.detailThuHocPhi[i].donGia3 = this.KhoanThuBanHang[j].donGia;
          }
        }
      }
    });
    // Khau Tru
    this.getDatas7().subscribe((data: any[]) => {
      this.KhoanChiMienGiam = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detailThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.KhoanChiMienGiam.length; j++ ){
          if (this.detailThuHocPhi[i].idKhoanChiMienGiam === this.KhoanChiMienGiam[j].id){
            this.detailThuHocPhi[i].khauTru = this.KhoanChiMienGiam[j].soTienMienGiam;
            this.detailThuHocPhi[i].tenKhoanChiMienGiam = this.KhoanChiMienGiam[j].tenKhoanChiMienGiam;
          }
        }
      }
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.detailThuHocPhi.length; i++) {
        // tslint:disable-next-line: max-line-length
        this.detailThuHocPhi[i].thanhTien = ((this.detailThuHocPhi[i].donGia1 * this.detailThuHocPhi[i].soLuong1) + (this.detailThuHocPhi[i].donGia2 * this.detailThuHocPhi[i].soLuong2) + (this.detailThuHocPhi[i].donGia3 * this.detailThuHocPhi[i].soLuong3));
      }
      this.test = this.detailThuHocPhi;
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
  getTotalCost() { return this.detailThuHocPhi.map(t => t.thanhTien).reduce((acc, value) => acc + value, 0); }
  // tslint:disable-next-line: typedef
  getTotalReduce() { return this.detailThuHocPhi.map(t => t.khauTru).reduce((acc, value) => acc + value, 0); }
  // tslint:disable-next-line: typedef
  getMustPay() { return this.getTotalCost() - this.getTotalReduce(); }
}


