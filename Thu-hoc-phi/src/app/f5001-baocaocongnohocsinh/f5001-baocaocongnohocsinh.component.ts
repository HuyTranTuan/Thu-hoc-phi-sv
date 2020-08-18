import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as xlsx from 'xlsx';

@Component({
  selector: 'app-f5001-baocaocongnohocsinh',
  templateUrl: './f5001-baocaocongnohocsinh.component.html',
  styleUrls: ['./f5001-baocaocongnohocsinh.component.scss']
})
export class F5001BaocaocongnohocsinhComponent implements OnInit {

  a: any;

  private apiUrl1 = 'https://localhost:44393/api/ThuHocPhis';
  private apiUrl2 = 'https://localhost:44393/api/HocSinhs';
  private apiUrl3 = 'https://localhost:44393/api/Lops';
  private apiUrl4 = 'https://localhost:44393/api/KhoanThuCoDinhs';
  private apiUrl5 = 'https://localhost:44393/api/KhoanThuDichVus';

  ThuHocPhi = []; HocSinh = []; Lop = []; CongNoHocPhi = []; CongNoDichVu = [];
  dataSource = new MatTableDataSource<any>();
  displayedColumns: string[] = ['idhocsinh', 'hoten', 'ngaysinh', 'gioitinh', 'lop', 'congnohocphi', 'congnodichvu', 'tongcongno'];

  @ViewChild('epltable', { static: false }) epltable: ElementRef;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.dataSource.paginator = this.paginator;
    this.getDatas1().subscribe((data: any[]) => { this.ThuHocPhi = data; });
    this.getDatas2().subscribe((data: any[]) => {
      this.HocSinh = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.HocSinh.length; j++) {
          if (this.ThuHocPhi[i].idHocSinh === this.HocSinh[j].id){
            this.ThuHocPhi[i].tenHocSinh = this.HocSinh[j].tenHocSinh;
            this.ThuHocPhi[i].ngaySinh = this.HocSinh[j].ngaySinh;
            this.ThuHocPhi[i].gioiTinh = this.HocSinh[j].gioiTinh;
            this.ThuHocPhi[i].idLop = this.HocSinh[j].idLop;
          }
        }
      }
    });
    this.getDatas3().subscribe((data: any[]) => {
      this.Lop = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.Lop.length; j++) {
          if (this.ThuHocPhi[i].idLop === this.Lop[j].id){
            this.ThuHocPhi[i].tenLop = this.Lop[j].tenLop;
          }
        }
      }
      console.log(this.ThuHocPhi);
    });
    this.getDatas4().subscribe((data: any[]) => {
      this.CongNoHocPhi = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.CongNoHocPhi.length; j++) {
          if (this.ThuHocPhi[i].idKhoanThuCoDinh === this.CongNoHocPhi[j].id){
            this.ThuHocPhi[i].donGia1 = this.CongNoHocPhi[j].donGia;
            this.ThuHocPhi[i].congNoHocPhi = this.ThuHocPhi[i].donGia1 * this.ThuHocPhi[i].soLuong1;
          }
        }
      }
    });
    this.getDatas5().subscribe((data: any[]) => {
      this.CongNoDichVu = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ThuHocPhi.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.CongNoDichVu.length; j++) {
          if (this.ThuHocPhi[i].idKhoanThuDichVu === this.CongNoDichVu[j].id){
            this.ThuHocPhi[i].donGia2 = this.CongNoDichVu[j].donGia;
            this.ThuHocPhi[i].congNoDichVu = this.ThuHocPhi[i].donGia2 * this.ThuHocPhi[i].soLuong2;
            this.ThuHocPhi[i].tongCongNo = this.ThuHocPhi[i].congNoDichVu + this.ThuHocPhi[i].congNoHocPhi;
          }
        }
      }
    });
  }
  reset(): void{ }

  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  getDatas3(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl3); }
  getDatas4(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl4); }
  getDatas5(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl5); }

  // tslint:disable-next-line: typedef
  getCongNoHocPhi() {  return this.ThuHocPhi.map(t => t.congNoHocPhi).reduce((acc, value) => acc + value, 0); }
  // tslint:disable-next-line: typedef
  getCongNoDichVu() { return this.ThuHocPhi.map(t => t.congNoDichVu).reduce((acc, value) => acc + value, 0); }
  // tslint:disable-next-line: typedef
  getTongCongNo() { return this.ThuHocPhi.map(t => t.tongCongNo).reduce((acc, value) => acc + value, 0); }
  // tslint:disable-next-line: typedef
  exportToExcel(){
    const ws: xlsx.WorkSheet = xlsx.utils.table_to_sheet(this.epltable.nativeElement);
    const wb: xlsx.WorkBook = xlsx.utils.book_new();
    xlsx.utils.book_append_sheet(wb, ws, 'Sheet1');
    xlsx.writeFile(wb, 'baocaocongnohocsinh.xlsx');
  }
}

