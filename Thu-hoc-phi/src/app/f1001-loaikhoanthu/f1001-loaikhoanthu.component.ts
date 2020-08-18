import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as xlsx from 'xlsx';

@Component({
  selector: 'app-f1001-loaikhoanthu',
  templateUrl: './f1001-loaikhoanthu.component.html',
  styleUrls: ['./f1001-loaikhoanthu.component.scss']
})
export class F1001LoaikhoanthuComponent implements OnInit {

  a: any;
  Id: number;
  TenLoaiKhoanThu: string;
  IdTinhChatKhoanThu: number;
  ThuTu: number;
  SuDung: boolean;
  displayedColumns: string[] = ['select', 'id', 'name', 'idtinhchatkhoanthu', 'thutu', 'use', 'edit', 'delete'];
  private apiUrl1 = 'https://localhost:44393/api/TinhChatKhoanThus';
  private apiUrl = 'https://localhost:44393/api/LoaiKhoanThus';
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
      console.log(this.ItemsArray);
      this.dataSource.data = this.ItemsArray;
    });
    this.getDatas1().subscribe((data: any[]) => {
      this.ItemsArray1 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++) {
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray1.length; j++) {
          // tslint:disable-next-line: no-conditional-assignment
          if (this.ItemsArray[i].idTinhChatKhoanThu === this.ItemsArray1[j].id) {
            this.ItemsArray[i].tenTinhChatKhoanThu = this.ItemsArray1[j].tenTinhChatKhoanThu;
          }
        }
      }
    });
  }

  // tslint:disable-next-line: typedef
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  // tslint:disable-next-line: typedef
  reset(){
    this.Id = null;
    this.TenLoaiKhoanThu = null;
    this.IdTinhChatKhoanThu = null;
    this.SuDung = null;
  }
  // tslint:disable-next-line: typedef
  deleteData(id: any){ return this.http.delete(this.apiUrl + `/${id}`).toPromise(); }
  reload(): void { location.reload(); }

  // tslint:disable-next-line: typedef
  exportToExcel(){
    const ws: xlsx.WorkSheet = xlsx.utils.table_to_sheet(this.epltable.nativeElement);
    const wb: xlsx.WorkBook = xlsx.utils.book_new();
    xlsx.utils.book_append_sheet(wb, ws, 'Sheet1');
    xlsx.writeFile(wb, 'loaikhoanthu.xlsx');
  }
  // tslint:disable-next-line: typedef
  getDimensionsByFind(){
    // tslint:disable-next-line: prefer-const
    let c = this.ItemsArray.find(x => x.idTinhChatKhoanThu === this.IdTinhChatKhoanThu);
    console.log(c);
  }
}
