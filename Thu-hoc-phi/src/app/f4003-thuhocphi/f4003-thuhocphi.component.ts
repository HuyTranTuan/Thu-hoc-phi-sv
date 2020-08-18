import { Component, OnInit } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-f4003-thuhocphi',
  templateUrl: './f4003-thuhocphi.component.html',
  styleUrls: ['./f4003-thuhocphi.component.scss']
})
export class F4003ThuhocphiComponent implements OnInit {

  Id: number;
  IdHocKy: number;
  IdKhoanThu: number;
  IdKhoanChiMienGiam: number;
  IdHocSinh: number;
  IdNguoiThu: number;
  IdHinhThucThu: number;
  SoLuong: number;
  private apiUrl = 'https://localhost:44393/api/ThuHocPhis';
  private apiUrl1 = 'https://localhost:44393/api/NguoiThus';
  private apiUrl2 = 'https://localhost:44393/api/KhoanChiMienGiams';
  private apiUrl3 = 'https://localhost:44393/api/KhoanThuCoDinhs';
  private apiUrl4 = 'https://localhost:44393/api/KhoanThuDichVus';
  private apiUrl5 = 'https://localhost:44393/api/KhoanThuBanHangs';
  private apiUrl6 = 'https://localhost:44393/api/HocSinhs';
  private apiUrl7 = 'https://localhost:44393/api/HinhThucThus';
  private apiUrl8 = 'https://localhost:44393/api/HocKies';
  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = []; ItemsArray3 = [];
  ItemsArray4 = []; ItemsArray5 = []; ItemsArray6 = []; ItemsArray7 = []; ItemsArray8 = [];

  ThuHocPhi = []; NguoiThu = []; KhoanChi = []; HocSinh = [];
  KhoanThuCoDinh = []; KhoanThuDichVu = []; KhoanThuBanHang = []; HinhThucThu = [];
  dataSource = new MatTableDataSource<any>();
  displayedColumns: string[] = ['id', 'hocsinh', 'hocky', 'khoanthucodinh', 'dongia1', 'soluong1', 'khoanthudichvu', 'dongia2', 'soluong2', 'khoanthubanhang', 'dongia3', 'soluong3', 'khoanchimiengiam', 'thanhtien', 'xoa'];
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    // tslint:disable-next-line: align
    this.getDatas().subscribe((data: any[]) => {
      this.ItemsArray = data;
      this.dataSource.data = this.ItemsArray;
      this.ThuHocPhi = this.ItemsArray;
    });
    this.getDatas1().subscribe((data: any[]) => {
      this.ItemsArray1 = data;
      this.NguoiThu = this.ItemsArray1;
    });
    this.getDatas2().subscribe((data: any[]) => {
      this.ItemsArray2 = data;
      for (let i = 0; i < this.ItemsArray.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray2.length; j++ ){
          if (this.ItemsArray[i].idKhoanChiMienGiam === this.ItemsArray2[j].id){
            this.ThuHocPhi[i].tenKhoanChiMienGiam = this.ItemsArray2[j].tenKhoanChiMienGiam;
            this.ThuHocPhi[i].soTienMienGiam = this.ItemsArray2[j].soTienMienGiam;
          }
        }
      }
    });
    this.getDatas3().subscribe((data: any[]) => {
      this.ItemsArray3 = data;
      for (let i = 0; i < this.ItemsArray.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray3.length; j++ ){
          if (this.ItemsArray[i].idKhoanThuCoDinh === this.ItemsArray3[j].id){
            this.ThuHocPhi[i].tenKhoanThuCoDinh = this.ItemsArray3[j].tenKhoanThuCoDinh;
            this.ThuHocPhi[i].donGiaKhoanThuCoDinh = this.ItemsArray3[j].donGia;
          }
        }
      }
    });
    this.getDatas4().subscribe((data: any[]) => {
      this.ItemsArray4 = data;
      for (let i = 0; i < this.ItemsArray.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray4.length; j++ ){
          if (this.ItemsArray[i].idKhoanThuDichVu === this.ItemsArray4[j].id){
            this.ThuHocPhi[i].tenKhoanThuDichVu = this.ItemsArray4[j].tenKhoanThuDichVu;
            this.ThuHocPhi[i].donGiaKhoanThuDichVu = this.ItemsArray4[j].donGia;
          }
        }
      }
    });
    this.getDatas5().subscribe((data: any[]) => {
      this.ItemsArray5 = data;
      for (let i = 0; i < this.ItemsArray.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray5.length; j++ ){
          if (this.ItemsArray[i].idKhoanThuBanHang === this.ItemsArray5[j].id){
            this.ThuHocPhi[i].tenKhoanThuBanHang = this.ItemsArray5[j].tenSanPham;
            this.ThuHocPhi[i].donGiaKhoanThuBanHang = this.ItemsArray5[j].donGia;
          }
        }
      }
    });
    this.getDatas6().subscribe((data: any[]) => {
      this.ItemsArray6 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray6.length; j++ ){
          if (this.ItemsArray[i].idHocSinh === this.ItemsArray6[j].id){
            this.ThuHocPhi[i].tenHocSinh = this.ItemsArray6[j].tenHocSinh;
          }
        }
      }
    });
    this.getDatas7().subscribe((data: any[]) => {
      this.ItemsArray7 = data;
      this.HinhThucThu = this.ItemsArray7;
    });
    this.getDatas8().subscribe((data: any[]) => {
      this.ItemsArray8 = data;
      for (let i = 0; i < this.ItemsArray.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray8.length; j++ ){
          if (this.ItemsArray[i].idHocKy === this.ItemsArray8[j].id){
            this.ThuHocPhi[i].tenHocKy = this.ItemsArray8[j].tenHocKy;
          }
        }
      }
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++) {
        // tslint:disable-next-line: max-line-length
        this.ThuHocPhi[i].thanhTien = ((this.ThuHocPhi[i].soLuong1 * this.ThuHocPhi[i].donGiaKhoanThuCoDinh) + (this.ThuHocPhi[i].soLuong2 * this.ThuHocPhi[i].donGiaKhoanThuDichVu) + (this.ThuHocPhi[i].soLuong3 * this.ThuHocPhi[i].donGiaKhoanThuBanHang)) - this.ThuHocPhi[i].soTienMienGiam;
      }
      console.log(this.ThuHocPhi);
    });
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
  // tslint:disable-next-line: typedef
  deleteData(id: any){ return this.http.delete(this.apiUrl + `/${id}`).toPromise(); }
  // tslint:disable-next-line: typedef
  reload() { location.reload(); }
}
