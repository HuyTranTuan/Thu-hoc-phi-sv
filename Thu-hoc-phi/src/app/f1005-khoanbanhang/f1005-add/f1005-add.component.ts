import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1005-add',
  templateUrl: './f1005-add.component.html',
  styleUrls: ['./f1005-add.component.scss']
})
export class F1005AddComponent implements OnInit {

  addForm: FormGroup;
  ItemsArray1 = []; ItemsArray2 = [];

  private apiUrl2 = 'https://localhost:44393/api/LoaiKhoanThus';
  private apiUrl1 = 'https://localhost:44393/api/LoaiSanPhams';
  private apiUrl = 'https://localhost:44393/api/KhoanThuBanHangs';
  constructor(private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    this.getDatas1().subscribe((data: any[]) => { this.ItemsArray1 = data; });
    this.getDatas2().subscribe((data: any[]) => { this.ItemsArray2 = data; });
    this.reactiveForm();
  }

  onSubmit(): void {
    this.http.post<any>(this.apiUrl, this.addForm.value).subscribe(
      (data: any) => {
        alert('Post method is succeed!');
        this.document.location.href = 'http://localhost:4200/khoanbanhang';
      },
      error => { alert('Post method is failed!'); }
    );
  }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.addForm = this.builder.group({
      TenSanPham: ['', [Validators.required, Validators.minLength(6)]],
      DonGia: ['', [Validators.required]],
      ThuTu: ['', ],
      SuDung: ['true'],
      IdLoaiKhoanThu: ['', [Validators.required]],
      IdLoaiSanPham: ['', [Validators.required]]
    });
  }

  get TenSanPham(): any { return this.addForm.get('TenSanPham'); }
  get IdLoaiKhoanThu(): any { return this.addForm.get('IdLoaiKhoanThu'); }
  get IdLoaiSanPham(): any { return this.addForm.get('IdLoaiSanPham'); }
  get DonGia(): any { return this.addForm.get('DonGia'); }
  get ThuTu(): any { return this.addForm.get('ThuTu'); }
  get SuDung(): any { return this.addForm.get('SuDung'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.addForm.controls[control].hasError(error); };
}
