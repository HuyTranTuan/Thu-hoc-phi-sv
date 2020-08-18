import { Component, OnInit, ViewChild } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-f4001-lapkehoachthu',
  templateUrl: './f4001-lapkehoachthu.component.html',
  styleUrls: ['./f4001-lapkehoachthu.component.scss']
})
export class F4001LapkehoachthuComponent implements OnInit {
  Id: number;
  SoLuongHocSinh: number;
  BatBuoc: boolean;
  IdHocKy: number;
  IdKhoi: number;
  IdHinhThucThu: number;
  IdKhoanThuCoDinh: number;
  GhiChu: string;
  // tslint:disable-next-line: max-line-length
  displayedColumns: string[] = ['select', 'id', 'idhocky', 'idkhoi', 'idhinhthucthu', 'idkhoanthucodinh', 'soluonghocsinh', 'sotien', 'ghichu', 'batbuoc', 'edit', 'delete'];
  private apiUrl = 'https://localhost:44393/api/KeHoachThus';
  private apiUrl1 = 'https://localhost:44393/api/HocKies';
  private apiUrl2 = 'https://localhost:44393/api/Khois';
  private apiUrl3 = 'https://localhost:44393/api/HinhThucThus';
  private apiUrl4 = 'https://localhost:44393/api/KhoanThuCoDinhs';
  ItemsArray = []; ItemsArray1 = []; ItemsArray2 = []; ItemsArray3 = []; ItemsArray4 = [];
  dataSource = new MatTableDataSource<any>();

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
          if (this.ItemsArray[i].idHocKy === this.ItemsArray1[j].id){
            this.ItemsArray[i].tenHocKy = this.ItemsArray1[j].tenHocKy;
          }
        }
      }
    });
    this.getDatas2().subscribe((data: any[]) => {
      this.ItemsArray2 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray2.length; j++){
          if (this.ItemsArray[i].idKhoi === this.ItemsArray2[j].id){
            this.ItemsArray[i].tenKhoi = this.ItemsArray2[j].tenKhoi;
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
          if (this.ItemsArray[i].idHinhThucThu === this.ItemsArray3[j].id){
            this.ItemsArray[i].tenHinhThucThu = this.ItemsArray3[j].tenHinhThucThu;
          }
        }
      }
    });
    this.getDatas4().subscribe((data: any[]) => {
      this.ItemsArray4 = data;
      // tslint:disable-next-line: prefer-for-of
      for (let i = 0; i < this.ItemsArray.length; i++){
        // tslint:disable-next-line: prefer-for-of
        for (let j = 0; j < this.ItemsArray4.length; j++){
          if (this.ItemsArray[i].idKhoanThuCoDinh === this.ItemsArray4[j].id){
            this.ItemsArray[i].tenKhoanThuCoDinh = this.ItemsArray4[j].tenKhoanThuCoDinh;
            this.ItemsArray[i].donGia = this.ItemsArray4[j].donGia;
          }
        }
      }
    });
  }

  getDatas(): Observable<any[]> {return this.http.get<any[]>(this.apiUrl); }
  getDatas1(): Observable<any[]> {return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> {return this.http.get<any[]>(this.apiUrl2); }
  getDatas3(): Observable<any[]> {return this.http.get<any[]>(this.apiUrl3); }
  getDatas4(): Observable<any[]> {return this.http.get<any[]>(this.apiUrl4); }
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
  getTotalCost() { return this.ItemsArray.map(t => t.soLuongHocSinh).reduce((acc, value) => acc + value, 0); }
  // tslint:disable-next-line: typedef
  getTotalCost2() { return this.ItemsArray.map(t => t.donGia).reduce((acc, value) => acc + value, 0); }
}

