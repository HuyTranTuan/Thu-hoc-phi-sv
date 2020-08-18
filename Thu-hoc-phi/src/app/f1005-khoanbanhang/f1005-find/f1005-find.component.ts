import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { Validators, FormBuilder, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1005-find',
  templateUrl: './f1005-find.component.html',
  styleUrls: ['./f1005-find.component.scss']
})
export class F1005FindComponent implements OnInit {

  Id: number;
  editForm: FormGroup;
  ItemsArray1 = []; ItemsArray2 = [];

  private apiUrl2 = 'https://localhost:44393/api/LoaiKhoanThus';
  private apiUrl1 = 'https://localhost:44393/api/LoaiSanPhams';
  private apiUrl = 'https://localhost:44393/api/KhoanThuBanHangs';
  // tslint:disable-next-line: max-line-length
  constructor(private route: ActivatedRoute, private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    // tslint:disable-next-line: no-string-literal
    this.Id = this.route.snapshot.params['id'];
    this.getDatas1().subscribe((data: any[]) => { this.ItemsArray1 = data; });
    this.getDatas2().subscribe((data: any[]) => { this.ItemsArray2 = data; });
    this.reactiveForm();
  }
  // tslint:disable-next-line: typedef
  onSubmit(id: any){
    this.http.put<any>(this.apiUrl + `/${id}`, this.editForm.value).subscribe(
      (data: any) => {
        alert('Put method is succeed!');
        this.document.location.href = 'http://localhost:4200/khoanbanhang';
      },
      error => { alert('Put method is failed!'); }
    );
  }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  getDatas2(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.editForm = this.builder.group({
      Id: [this.Id, ],
      TenSanPham: ['', [Validators.required, Validators.minLength(6)]],
      DonGia: ['', [Validators.required]],
      ThuTu: ['', ],
      SuDung: ['true'],
      IdLoaiKhoanThu: ['', [Validators.required]],
      IdLoaiSanPham: ['', [Validators.required]]
    });
  }

  get TenSanPham(): any { return this.editForm.get('TenSanPham'); }
  get IdLoaiKhoanThu(): any { return this.editForm.get('IdLoaiKhoanThu'); }
  get IdLoaiSanPham(): any { return this.editForm.get('IdLoaiSanPham'); }
  get DonGia(): any { return this.editForm.get('DonGia'); }
  get ThuTu(): any { return this.editForm.get('ThuTu'); }
  get SuDung(): any { return this.editForm.get('SuDung'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.editForm.controls[control].hasError(error); };
}
