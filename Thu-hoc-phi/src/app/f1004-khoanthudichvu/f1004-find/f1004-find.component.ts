import { Component, OnInit, Inject  } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { Validators, FormBuilder, FormControl, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1004-find',
  templateUrl: './f1004-find.component.html',
  styleUrls: ['./f1004-find.component.scss']
})
export class F1004FindComponent implements OnInit {

  Id: number;
  editForm: FormGroup;
  ItemsArray = [];

  private apiUrl2 = 'https://localhost:44393/api/LoaiKhoanThus';
  private apiUrl = 'https://localhost:44393/api/KhoanThuDichVus';
  // tslint:disable-next-line: max-line-length
  constructor(private route: ActivatedRoute, private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    // tslint:disable-next-line: no-string-literal
    this.Id = this.route.snapshot.params['id'];
    this.getDatas().subscribe((data: any[]) => { this.ItemsArray = data; });
    this.reactiveForm();
  }

  // tslint:disable-next-line: typedef
  onSubmit(id: any){
    this.http.put<any>(this.apiUrl + `/${id}`, this.editForm.value).subscribe(
      (data: any) => {
        alert('Put method is succeed!');
        this.document.location.href = 'http://localhost:4200/khoanthudichvu';
      },
      error => { alert('Put method is failed!'); }
    );
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.editForm = this.builder.group({
      Id: [this.Id, ],
      TenKhoanThuDichVu: ['', [Validators.required, Validators.minLength(6)]],
      DonGia: ['', [Validators.required]],
      DonGiaTra: ['', [Validators.required]],
      ThuTu: ['', ],
      SuDung: ['true'],
      GhiChu: ['', ],
      TinhTheoNgay: ['true', [Validators.required]],
      TraLaiKhiVang: ['true', ],
      IdLoaiKhoanThu: ['', [Validators.required]]
    });
  }

  get TenKhoanThuDichVu(): any { return this.editForm.get('TenKhoanThuDichVu'); }
  get DonGia(): any { return this.editForm.get('DonGia'); }
  get DonGiaTra(): any { return this.editForm.get('DonGiaTra'); }
  get ThuTu(): any { return this.editForm.get('ThuTu'); }
  get SuDung(): any { return this.editForm.get('SuDung'); }
  get GhiChu(): any { return this.editForm.get('GhiChu'); }
  get TinhTheoNgay(): any { return this.editForm.get('TinhTheoNgay'); }
  get TraLaiKhiVang(): any { return this.editForm.get('TraLaiKhiVang'); }
  get IdLoaiKhoanThu(): any { return this.editForm.get('IdLoaiKhoanThu'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.editForm.controls[control].hasError(error); };
}
