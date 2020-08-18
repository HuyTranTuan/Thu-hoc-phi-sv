import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as xlsx from 'xlsx';
import { NgxPrintModule } from 'ngx-print';

@Component({
  selector: 'app-f2001-qldangkydichvu',
  templateUrl: './f2001-qldangkydichvu.component.html',
  styleUrls: ['./f2001-qldangkydichvu.component.scss']
})
export class F2001QldangkydichvuComponent implements OnInit {
  a = [];
  b: any;
  c: boolean;

  Id: number;
  IdHocSinh: number;
  IdDotThu: string;
  IdKhoanThuDicVu: number;
  SoLuong: number;
  GhiChu: string;
  private apiUrl = 'https://localhost:44393/api/DangKyDichVus';
  private apiUrl1 = 'https://localhost:44393/api/HocSinhs';
  private apiUrl2 = 'https://localhost:44393/api/KhoanThuDichVus';
  private apiUrl3 = 'https://localhost:44393/api/DotThus';
  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = []; ItemsArray3 = [];
  DangKyDichVus = []; HocSinhs = []; KhoanThuDichVus = [];
  TheoNgay = []; TheoDot = [];
  dataSource = new MatTableDataSource<any>();
  // tslint:disable-next-line: max-line-length
  displayedColumns: string[] = ['select', 'id', 'idhocsinh', 'iddotthu', 'idkhoanthu', 'dvt', 'sotien', 'soluong', 'thanhtien', 'ghichu', 'edit', 'delete'];

  @ViewChild('epltable', { static: false }) epltable: ElementRef;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.dataSource.paginator = this.paginator;
    // tslint:disable-next-line: align
    this.getDatas().subscribe((data: any[]) => {
      this.ItemsArray = data;
      this.dataSource.data = this.ItemsArray;
      this.DangKyDichVus = this. ItemsArray;
    });
    this.getDatas1().subscribe((data: any[]) => {
      this.ItemsArray1 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray1.length; j++){
          if (this.ItemsArray[i].idHocSinh === this.ItemsArray1[j].id){
            this.ItemsArray[i].tenHocSinh = this.ItemsArray1[j].tenHocSinh;
          }
        }
      }
    });
    this.getDatas2().subscribe((data: any[]) => {
      this.ItemsArray2 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray2.length; i++ ){
        if (this.ItemsArray2[i].tinhTheoNgay === true){
          this.TheoNgay.push(this.ItemsArray2[i]);
        }
        else {
          this.TheoDot.push(this.ItemsArray2[i]);
        }
      }
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray2.length; j++){
          if (this.ItemsArray[i].idKhoanThuDichVu === this.ItemsArray2[j].id){
            this.ItemsArray[i].tenKhoanThuDichVu = this.ItemsArray2[j].tenKhoanThuDichVu;
            this.ItemsArray[i].donGia = this.ItemsArray2[j].donGia;
            this.ItemsArray[i].thanhTien = this.ItemsArray[i].donGia * this.ItemsArray[i].soLuong;
          }
        }
      }
    });
    this.getDatas3().subscribe((data: any[]) => {
      this.ItemsArray3 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray3.length; j++){
          if (this.ItemsArray[i].idDotThu === this.ItemsArray3[j].id){
            this.ItemsArray[i].tenDotThu = this.ItemsArray3[j].tenDotThu;
          }
        }
      }
    });
  }

  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  getDatas3(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl3); }
  // tslint:disable-next-line: typedef
  deleteData(id: any){ return this.http.delete(this.apiUrl + `/${id}`).toPromise(); }
  // tslint:disable-next-line: typedef
  reload(){ location.reload(); }
  // tslint:disable-next-line: typedef
  exportToExcel(){
    const ws: xlsx.WorkSheet = xlsx.utils.table_to_sheet(this.epltable.nativeElement);
    const wb: xlsx.WorkBook = xlsx.utils.book_new();
    xlsx.utils.book_append_sheet(wb, ws, 'Sheet1');
    xlsx.writeFile(wb, 'qldangkydichvu.xlsx');
  }
}

