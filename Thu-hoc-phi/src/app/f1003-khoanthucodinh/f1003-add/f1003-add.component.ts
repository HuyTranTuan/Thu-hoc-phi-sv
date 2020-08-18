import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormControl, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1003-add',
  templateUrl: './f1003-add.component.html',
  styleUrls: ['./f1003-add.component.scss']
})
export class F1003AddComponent implements OnInit {

  addForm: FormGroup;
  ItemsArray = [];

  private apiUrl2 = 'https://localhost:44393/api/LoaiKhoanThus';
  private apiUrl = 'https://localhost:44393/api/KhoanThuCoDinhs';
  constructor(private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    this.getDatas().subscribe((data: any[]) => { this.ItemsArray = data; });
    this.reactiveForm();
  }
  onSubmit(): void {
    this.http.post<any>(this.apiUrl, this.addForm.value).subscribe(
      (data: any) => {
        alert('Post method is succeed!');
        this.document.location.href = 'http://localhost:4200/khoanthucodinh';
      },
      error => { alert('Post method is failed!'); }
    );
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.addForm = this.builder.group({
      TenKhoanThuCoDinh: ['', [Validators.required, Validators.minLength(6)]],
      DonGia: ['', [Validators.required]],
      GhiChu: ['', ],
      IdLoaiKhoanThu: ['', [Validators.required]],
      ThuTu: ['', ],
      SuDung: ['true']
    });
  }

  get TenKhoanThuCoDinh(): any { return this.addForm.get('TenKhoanThuCoDinh'); }
  get IdLoaiKhoanThu(): any { return this.addForm.get('IdLoaiKhoanThu'); }
  get DonGia(): any { return this.addForm.get('DonGia'); }
  get GhiChu(): any { return this.addForm.get('GhiChu'); }
  get ThuTu(): any { return this.addForm.get('ThuTu'); }
  get SuDung(): any { return this.addForm.get('SuDung'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.addForm.controls[control].hasError(error); };
}
