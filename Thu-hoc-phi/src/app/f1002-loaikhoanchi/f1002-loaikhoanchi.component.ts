import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import * as xlsx from 'xlsx';

@Component({
  selector: 'app-f1002-loaikhoanchi',
  templateUrl: './f1002-loaikhoanchi.component.html',
  styleUrls: ['./f1002-loaikhoanchi.component.scss']
})
export class F1002LoaikhoanchiComponent implements OnInit {

  a: any;
  Id: number;
  TenLoaiKhoanChi: string;
  ThuTu: number;
  SuDung: boolean;
  displayedColumns: string[] = ['select', 'id', 'name', 'thutu', 'use', 'edit', 'delete'];
  private apiUrl = 'https://localhost:44393/api/LoaiKhoanChis';
  ItemsArray = [];
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
  }

  // tslint:disable-next-line: typedef
  reset(){
    this.Id = null;
    this.TenLoaiKhoanChi = null;
  }
  // tslint:disable-next-line: typedef
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  // tslint:disable-next-line: typedef
  deleteData(id: any){ return this.http.delete(this.apiUrl + `/${id}`).toPromise(); }
  // tslint:disable-next-line: typedef
  reload(){ location.reload(); }
  // tslint:disable-next-line: typedef
  exportToExcel(){
    const ws: xlsx.WorkSheet = xlsx.utils.table_to_sheet(this.epltable.nativeElement);
    const wb: xlsx.WorkBook = xlsx.utils.book_new();
    xlsx.utils.book_append_sheet(wb, ws, 'Sheet1');
    xlsx.writeFile(wb, 'loaikhoanchi.xlsx');
  }
}

