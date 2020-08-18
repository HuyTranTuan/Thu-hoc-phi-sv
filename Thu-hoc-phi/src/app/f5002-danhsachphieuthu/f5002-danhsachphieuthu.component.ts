import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as xlsx from 'xlsx';

@Component({
  selector: 'app-f5002-danhsachphieuthu',
  templateUrl: './f5002-danhsachphieuthu.component.html',
  styleUrls: ['./f5002-danhsachphieuthu.component.scss']
})
export class F5002DanhsachphieuthuComponent implements OnInit {
  a: any;
  private apiUrl1 = 'https://localhost:44393/api/ThuHocPhis';
  private apiUrl2 = 'https://localhost:44393/api/HocSinhs';
  private apiUrl3 = 'https://localhost:44393/api/HinhThucThus';
  private apiUrl4 = 'https://localhost:44393/api/Lops';
  private apiUrl5 = 'https://localhost:44393/api/NguoiThus';
  private apiUrl6 = 'https://localhost:44393/api/KhoanThuCoDinhs';
  private apiUrl7 = 'https://localhost:44393/api/KhoanThuDichVus';
  private apiUrl8 = 'https://localhost:44393/api/KhoanThuBanHangs';
  ThuHocPhi = []; HocSinh = []; HinhThucThu = []; Lop = []; NguoiThu = [];
  KhoanThuCoDinh = []; KhoanThuDichVu = []; KhoanThuBanHang = [];

  // tslint:disable-next-line: max-line-length
  displayedColumns: string[] = ['id', 'idhocsinh', 'hoten', 'lop', 'nguoithu', 'ngaythu', 'hinhthucthu', 'tongtien', 'chitiet', 'inbienlai'];
  dataSource = new MatTableDataSource<any>();

  @ViewChild('epltable', { static: false }) epltable: ElementRef;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.dataSource.paginator = this.paginator;
    this.getDatas1().subscribe((data: any[]) => { this.ThuHocPhi = data; });
    this.getDatas2().subscribe((data: any[]) => {
      this.HocSinh = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++ ){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.HocSinh.length; j++) {
          if (this.ThuHocPhi[i].idHocSinh === this.HocSinh[j].id) {
            this.ThuHocPhi[i].tenHocSinh = this.HocSinh[j].tenHocSinh;
            this.ThuHocPhi[i].ngaySinh = this.HocSinh[j].ngaySinh;
            this.ThuHocPhi[i].gioiTinh = this.HocSinh[j].gioiTinh;
            this.ThuHocPhi[i].idLop = this.HocSinh[j].idLop;
          }
        }
      }
    });
    this.getDatas3().subscribe((data: any[]) => {
      this.HinhThucThu = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.HinhThucThu.length; j++) {
          if (this.ThuHocPhi[i].idHinhThucThu === this.HinhThucThu[j].id) {
            this.ThuHocPhi[i].tenHinhThucThu = this.HinhThucThu[j].tenHinhThucThu;
          }
        }
      }
    });
    this.getDatas4().subscribe((data: any[]) => {
      this.Lop = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.Lop.length; j++) {
          if (this.ThuHocPhi[i].idLop === this.Lop[j].id) {
            this.ThuHocPhi[i].tenLop = this.Lop[j].tenLop;
          }
        }
      }
    });
    this.getDatas5().subscribe((data: any[]) => {
      this.NguoiThu = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.NguoiThu.length; j++) {
          if (this.ThuHocPhi[i].idNguoiThu === this.NguoiThu[j].id) {
            this.ThuHocPhi[i].tenNguoiThu = this.NguoiThu[j].tenNguoiThu;
          }
        }
      }
    });
    this.getDatas6().subscribe((data: any[]) => {
      this.KhoanThuCoDinh = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.KhoanThuCoDinh.length; j++) {
          if (this.ThuHocPhi[i].idKhoanThuCoDinh === this.KhoanThuCoDinh[j].id) {
            this.ThuHocPhi[i].tenKhoanThuCoDinh = this.KhoanThuCoDinh[j].tenKhoanThuCoDinh;
            this.ThuHocPhi[i].donGia1 = this.KhoanThuCoDinh[j].donGia;
          }
        }
      }
    });
    this.getDatas7().subscribe((data: any[]) => {
      this.KhoanThuDichVu = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.KhoanThuDichVu.length; j++) {
          if (this.ThuHocPhi[i].idKhoanThuDichVu === this.KhoanThuDichVu[j].id) {
            this.ThuHocPhi[i].tenKhoanThuDichVu = this.KhoanThuDichVu[j].tenKhoanThuDichVu;
            this.ThuHocPhi[i].donGia2 = this.KhoanThuDichVu[j].donGia;
          }
        }
      }
    });
    this.getDatas8().subscribe((data: any[]) => {
      this.KhoanThuBanHang = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.KhoanThuBanHang.length; j++) {
          if (this.ThuHocPhi[i].idKhoanThuBanHang === this.KhoanThuBanHang[j].id) {
            this.ThuHocPhi[i].tenKhoanThuBanHang = this.KhoanThuBanHang[j].tenKhoanThuBanHang;
            this.ThuHocPhi[i].donGia3 = this.KhoanThuBanHang[j].donGia;
          }
        }
      }
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: max-line-length
        this.ThuHocPhi[i].tongTien = ((this.ThuHocPhi[i].soLuong1 * this.ThuHocPhi[i].donGia1) + (this.ThuHocPhi[i].soLuong2 * this.ThuHocPhi[i].donGia2) + (this.ThuHocPhi[i].soLuong3 * this.ThuHocPhi[i].donGia3));
      }
    });
  }

  // tslint:disable-next-line: typedef
  getTotalCost() { return this.ThuHocPhi.map(t => t.tongTien).reduce((acc, value) => acc + value, 0); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  getDatas3(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl3); }
  getDatas4(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl4); }
  getDatas5(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl5); }
  getDatas6(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl6); }
  getDatas7(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl7); }
  getDatas8(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl8); }

  // tslint:disable-next-line: typedef
  exportToExcel(){
    const ws: xlsx.WorkSheet = xlsx.utils.table_to_sheet(this.epltable.nativeElement);
    const wb: xlsx.WorkBook = xlsx.utils.book_new();
    xlsx.utils.book_append_sheet(wb, ws, 'Sheet1');
    xlsx.writeFile(wb, 'danhsachkhoanthu.xlsx');
  }
}
