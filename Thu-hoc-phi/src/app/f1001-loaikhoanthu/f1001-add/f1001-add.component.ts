import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormControl, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1001-add',
  templateUrl: './f1001-add.component.html',
  styleUrls: ['./f1001-add.component.scss']
})
export class F1001AddComponent implements OnInit {

  addForm: FormGroup;
  ItemsArray = [];

  private apiUrl2 = 'https://localhost:44393/api/TinhChatKhoanThus';
  private apiUrl = 'https://localhost:44393/api/LoaiKhoanThus';
  constructor(private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) {}

  ngOnInit(): void {
    this.getDatas().subscribe((data: any[]) => { this.ItemsArray = data; });
    this.reactiveForm();
  }
  // postData(): void {
  //   this.http.post<any>(this.apiUrl, {
  //     Id:  this.Id,
  //     TenLoaiKhoanThu:  this.TenLoaiKhoanThu,
  //     IdTinhChatKhoanThu:  this.IdTinhChatKhoanThu,
  //     ThuTu: this.ThuTu,
  //     SuDung: this.SuDung
  //   }).subscribe( (data: any) =>  {});
  //   alert('Post data success!');
  // }
  onSubmit(): void {
    this.http.post(this.apiUrl, this.addForm.value).subscribe(
      (data: any) => {
        alert('Post method is succeed!');
        this.document.location.href = 'http://localhost:4200/loaikhoanthu';
      },
      error => { alert('Post method is failed!'); }
    );
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.addForm = this.builder.group({
      TenLoaiKhoanThu: ['', [Validators.required, Validators.minLength(6)]],
      IdTinhChatKhoanThu: ['', [Validators.required]],
      ThuTu: ['', ],
      SuDung: ['true']
    });
  }

  get TenLoaiKhoanThu(): any { return this.addForm.get('TenLoaiKhoanThu'); }
  get IdTinhChatKhoanThu(): any { return this.addForm.get('IdTinhChatKhoanThu'); }
  get ThuTu(): any { return this.addForm.get('ThuTu'); }
  get SuDung(): any { return this.addForm.get('SuDung'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.addForm.controls[control].hasError(error); };

}
