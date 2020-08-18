import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as xlsx from 'xlsx';

@Component({
  selector: 'app-f1007-khoanchimiengiam',
  templateUrl: './f1007-khoanchimiengiam.component.html',
  styleUrls: ['./f1007-khoanchimiengiam.component.scss']
})
export class F1007KhoanchimiengiamComponent implements OnInit {

  Id: number;
  TenKhoanChiMienGiam: string;
  SoTienMienGiam: number;
  IdKhoanChi: number;
  GhiChu: string;
  displayedColumns: string[] = ['select', 'id', 'ten', 'idkhoanchi', 'sotienmiengiam', 'ghichu', 'edit', 'delete'];
  private apiUrl = 'https://localhost:44393/api/KhoanChiMienGiams';
  private apiUrl1 = 'https://localhost:44393/api/KhoanChis';
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
      for (let i = 0; i < this.ItemsArray.length; i++){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray1.length; j++){
          if (this.ItemsArray[i].idKhoanChi === this.ItemsArray1[j].id){
            this.ItemsArray[i].tenKhoanChi = this.ItemsArray1[j].tenKhoanChi;
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
    this.GhiChu = null;
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
    xlsx.writeFile(wb, 'khoanchimiengiam.xlsx');
  }
}

