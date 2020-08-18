import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as xlsx from 'xlsx';

@Component({
  selector: 'app-f1003-khoanthucodinh',
  templateUrl: './f1003-khoanthucodinh.component.html',
  styleUrls: ['./f1003-khoanthucodinh.component.scss']
})
export class F1003KhoanthucodinhComponent implements OnInit {

  Id: number;
  TenKhoanThuCoDinh: string;
  DonGia: number;
  ThuTu: number;
  GhiChu: string;
  SuDung: boolean;
  IdLoaiKhoanThu: number;
  displayedColumns: string[] = ['select', 'id', 'name', 'dongia', 'thutu', 'ghichu', 'idloaikhoanthu', 'use', 'edit', 'delete'];
  private apiUrl = 'https://localhost:44393/api/KhoanThuCoDinhs';
  private apiUrl1 = 'https://localhost:44393/api/LoaiKhoanThus';
  ItemsArray = [];
  ItemsArray1 = [];
  dataSource = new MatTableDataSource<any>();

  @ViewChild('epltable', { static: false }) epltable: ElementRef;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.dataSource.paginator = this.paginator;
    // tslint:disable-next-line: align
    this.getDatas().subscribe((data: any[]) => {
      this.ItemsArray = data;
      console.log(this.ItemsArray);
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
  }

  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  // tslint:disable-next-line: typedef
  reset(){
    this.Id = null;
    this.TenKhoanThuCoDinh = null;
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
    xlsx.writeFile(wb, 'khoanthucodinh.xlsx');
  }
}
