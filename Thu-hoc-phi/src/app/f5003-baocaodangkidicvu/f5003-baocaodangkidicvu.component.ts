import { Component, OnInit, ViewChild, ElementRef  } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as xlsx from 'xlsx';

@Component({
  selector: 'app-f5003-baocaodangkidicvu',
  templateUrl: './f5003-baocaodangkidicvu.component.html',
  styleUrls: ['./f5003-baocaodangkidicvu.component.scss']
})
export class F5003BaocaodangkidicvuComponent implements OnInit {
  @ViewChild('epltable', { static: false }) epltable: ElementRef;
  a: any;
  b = [];
  private apiUrl1 = 'https://localhost:44393/api/DangKyDichVus';
  private apiUrl2 = 'https://localhost:44393/api/HocSinhs';
  private apiUrl3 = 'https://localhost:44393/api/KhoanThuDichVus';
  private apiUrl4 = 'https://localhost:44393/api/DotThus';
  private apiUrl0 = 'https://localhost:44393/api/Lops';
  DangKyDichVu = []; HocSinh = []; KhoanThuDichVu = []; DotThu = []; Lop = [];
  dataSource = new MatTableDataSource<any>();
  displayedColumns: string[] = ['id', 'thang', 'idhocsinh', 'hoten', 'ngaysinh', 'gioitinh', 'lop', 'khoanthudichvu', 'dongia', 'soluong', 'thanhtien'];
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.dataSource.paginator = this.paginator;
    this.getDatas1().subscribe((data: any[]) => { this.DangKyDichVu = data; });
    this.getDatas2().subscribe((data: any[]) => {
      this.HocSinh = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.DangKyDichVu.length; i++ ){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.HocSinh.length; j++) {
          if (this.DangKyDichVu[i].idHocSinh === this.HocSinh[j].id) {
            this.DangKyDichVu[i].tenHocSinh = this.HocSinh[j].tenHocSinh;
            this.DangKyDichVu[i].ngaySinh = this.HocSinh[j].ngaySinh;
            this.DangKyDichVu[i].gioiTinh = this.HocSinh[j].gioiTinh;
            this.DangKyDichVu[i].idLop = this.HocSinh[j].idLop;
          }
        }
      }
    });
    this.getDatas0().subscribe((data: any[]) => {
      this.Lop = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.DangKyDichVu.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.Lop.length; j++) {
          if (this.DangKyDichVu[i].idLop === this.Lop[j].id){
            this.DangKyDichVu[i].tenLop = this.Lop[j].tenLop;
          }
        }
      }
    });
    this.getDatas3().subscribe((data: any[]) => {
      this.KhoanThuDichVu = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.DangKyDichVu.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.KhoanThuDichVu.length; j++) {
          if (this.DangKyDichVu[i].idKhoanThuDichVu === this.KhoanThuDichVu[j].id){
            this.DangKyDichVu[i].tenKhoanThuDichVu = this.KhoanThuDichVu[j].tenKhoanThuDichVu;
            this.DangKyDichVu[i].donGia = this.KhoanThuDichVu[j].donGia;
            this.DangKyDichVu[i].thanhTien = this.DangKyDichVu[i].donGia * this.DangKyDichVu[i].soLuong;
          }
        }
      }
    });
    this.getDatas4().subscribe((data: any[]) => {
      this.DotThu = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.DangKyDichVu.length; i++ ){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.DotThu.length; j++) {
          if (this.DangKyDichVu[i].idDotThu === this.DotThu[j].id) {
            this.DangKyDichVu[i].tenDotThu = this.DotThu[j].tenDotThu;
          }
        }
      }
    });
  }
  // tslint:disable-next-line: typedef
  exportToExcel(){
    const ws: xlsx.WorkSheet = xlsx.utils.table_to_sheet(this.epltable.nativeElement);
    const wb: xlsx.WorkBook = xlsx.utils.book_new();
    xlsx.utils.book_append_sheet(wb, ws, 'Sheet1');
    xlsx.writeFile(wb, 'baocaodangkydichvu.xlsx');
  }

  getDatas0(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl0); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  getDatas3(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl3); }
  getDatas4(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl4); }
}

