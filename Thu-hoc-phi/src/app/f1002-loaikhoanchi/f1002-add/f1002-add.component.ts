import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormControl, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1002-add',
  templateUrl: './f1002-add.component.html',
  styleUrls: ['./f1002-add.component.scss']
})
export class F1002AddComponent implements OnInit {

  addForm: FormGroup;
  private apiUrl = 'https://localhost:44393/api/LoaiKhoanChis';
  constructor(private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void { this.reactiveForm(); }

  onSubmit(): void {
    this.http.post<any>(this.apiUrl, this.addForm.value).subscribe(
      (data: any) => {
        alert('Post method is succeed!');
        this.document.location.href = 'http://localhost:4200/loaikhoanchi';
      },
      error => { alert('Post method is failed!'); }
    );
  }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.addForm = this.builder.group({
      TenLoaiKhoanChi: ['', [Validators.required, Validators.minLength(6)]],
      ThuTu: ['', ],
      SuDung: ['true']
    });
  }
  get TenLoaiKhoanChi(): any { return this.addForm.get('TenLoaiKhoanChi'); }
  get ThuTu(): any { return this.addForm.get('ThuTu'); }
  get SuDung(): any { return this.addForm.get('SuDung'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.addForm.controls[control].hasError(error); };
}
