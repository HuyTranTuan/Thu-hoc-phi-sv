import { Component, OnInit } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatTableDataSource } from '@angular/material/table';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-f4001-dodukienhocsinh',
  templateUrl: './f4001-dodukienhocsinh.component.html',
  styleUrls: ['./f4001-dodukienhocsinh.component.scss']
})
export class F4001DodukienhocsinhComponent implements OnInit {

  a: any;
  displayedColumns: string[] = ['select', 'stt', 'mahs', 'hoten', 'gioitinh', 'ngaysinh', 'lophoc'];
  private apiUrl = 'https://localhost:44393/api/HocSinhs';
  private apiUrl1 = 'https://localhost:44393/api/';
  ItemsArray = [];
  dataSource = new MatTableDataSource<any>();
  constructor() { }

  ngOnInit(): void {
  }

}
export interface PeriodicElement {
  stt: number;
  mahs: string;
  lophoc: string;
  hoten: string;
  ngaysinh: string;
  gioitinh: string;
}
