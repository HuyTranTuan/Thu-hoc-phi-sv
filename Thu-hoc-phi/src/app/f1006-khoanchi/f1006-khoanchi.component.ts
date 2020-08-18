import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as xlsx from 'xlsx';


@Component({
  selector: 'app-f1006-khoanchi',
  templateUrl: './f1006-khoanchi.component.html',
  styleUrls: ['./f1006-khoanchi.component.scss']
})
export class F1006KhoanchiComponent implements OnInit {

  Id: number;
  TenKhoanChi: string;
  ThuTu: number;
  SuDung: boolean;
  IdLoaiKhoanChi: number;
  displayedColumns: string[] = ['select', 'id', 'name', 'thutu', 'idloaikhoanchi', 'use', 'edit', 'delete'];
  private apiUrl = 'https://localhost:44393/api/KhoanChis';
  private apiUrl1 = 'https://localhost:44393/api/LoaiKhoanChis';
  ItemsArray = []; ItemsArray1 = [];
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
          if (this.ItemsArray[i].idLoaiKhoanChi === this.ItemsArray1[j].id){
            this.ItemsArray[i].tenLoaiKhoanChi = this.ItemsArray1[j].tenLoaiKhoanChi;
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
    this.TenKhoanChi = null;
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
    xlsx.writeFile(wb, 'khoanchi.xlsx');
  }
}
