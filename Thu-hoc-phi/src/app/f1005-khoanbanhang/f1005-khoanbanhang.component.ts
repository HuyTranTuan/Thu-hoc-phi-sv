import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as xlsx from 'xlsx';

@Component({
  selector: 'app-f1005-khoanbanhang',
  templateUrl: './f1005-khoanbanhang.component.html',
  styleUrls: ['./f1005-khoanbanhang.component.scss']
})
export class F1005KhoanbanhangComponent implements OnInit {

  Id: number;
  TenSanPham: string;
  DonGia: number;
  ThuTu: number;
  SuDung: boolean;
  IdLoaiKhoanThu: number;
  IdLoaiSanPham: number;
  displayedColumns: string[] = ['select', 'id', 'name', 'dongia', 'thutu', 'idloaisanpham', 'idloaikhoanthu', 'use', 'edit', 'delete'];
  private apiUrl = 'https://localhost:44393/api/KhoanThuBanHangs';
  private apiUrl1 = 'https://localhost:44393/api/LoaiKhoanThus';
  private apiUrl2 = 'https://localhost:44393/api/LoaiSanPhams';
  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = [];
  dataSource = new MatTableDataSource<any>();

  @ViewChild('epltable', { static: false }) epltable: ElementRef;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.dataSource.paginator = this.paginator;
    // tslint:disable-next-line: align
    this.getDatas().subscribe((data: any[]) => {
      this.ItemsArray = data;
      this.dataSource.data = this.ItemsArray;
    });
    this.getDatas1().subscribe((data: any[]) => {
      this.ItemsArray1 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray1.length; j++){
          if (this.ItemsArray[i].idLoaiKhoanThu === this.ItemsArray1[j].id){
            this.ItemsArray[i].tenLoaiKhoanThu = this.ItemsArray1[j].tenLoaiKhoanThu;
          }
        }
      }
    });
    this.getDatas2().subscribe((data: any[]) => {
      this.ItemsArray1 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray1.length; j++){
          if (this.ItemsArray[i].idLoaiSanPham === this.ItemsArray1[j].id){
            this.ItemsArray[i].tenLoaiSanPham = this.ItemsArray1[j].tenLoaiSanPham;
          }
        }
      }
    });
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  // tslint:disable-next-line: typedef
  reset(){
    this.Id = null;
    this.TenSanPham = null;
  }

  // tslint:disable-next-line: typedef
  deleteData(id: any){ return this.http.delete(this.apiUrl + `/${id}`).toPromise(); }
  // tslint:disable-next-line: typedef
  reload(){ location.reload(); }
  // tslint:disable-next-line: typedef
  exportToExcel(){
    const ws: xlsx.WorkSheet = xlsx.utils.table_to_sheet(this.epltable.nativeElement);
    const wb: xlsx.WorkBook = xlsx.utils.book_new();
    xlsx.utils.book_append_sheet(wb, ws, 'Sheet1');
    xlsx.writeFile(wb, 'khoanthubanhang.xlsx');
  }
}

