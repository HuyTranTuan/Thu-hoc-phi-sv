import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1006-add',
  templateUrl: './f1006-add.component.html',
  styleUrls: ['./f1006-add.component.scss']
})
export class F1006AddComponent implements OnInit {

  addForm: FormGroup;
  ItemsArray = [];

  private apiUrl1 = 'https://localhost:44393/api/LoaiKhoanChis';
  private apiUrl = 'https://localhost:44393/api/KhoanChis';
  constructor(private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    this.getDatas1().subscribe((data: any[]) => { this.ItemsArray = data; });
    this.reactiveForm();
  }
  onSubmit(): void {
    this.http.post<any>(this.apiUrl, this.addForm.value).subscribe(
      (data: any) => {
        alert('Post method is succeed!');
        this.document.location.href = 'http://localhost:4200/khoanchi';
      },
      error => { alert('Post method is failed!'); }
    );
  }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.addForm = this.builder.group({
      TenKhoanChi: ['', [Validators.required, Validators.minLength(6)]],
      IdLoaiKhoanChi: ['', [Validators.required]],
      ThuTu: ['', ],
      SuDung: ['true']
    });
  }

  get TenKhoanChi(): any { return this.addForm.get('TenKhoanChi'); }
  get IdLoaiKhoanChi(): any { return this.addForm.get('IdLoaiKhoanChi'); }
  get ThuTu(): any { return this.addForm.get('ThuTu'); }
  get SuDung(): any { return this.addForm.get('SuDung'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.addForm.controls[control].hasError(error); };
}
