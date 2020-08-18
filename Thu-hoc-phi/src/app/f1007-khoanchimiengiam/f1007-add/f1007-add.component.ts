import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1007-add',
  templateUrl: './f1007-add.component.html',
  styleUrls: ['./f1007-add.component.scss']
})
export class F1007AddComponent implements OnInit {

  addForm: FormGroup;
  ItemsArray = [];

  private apiUrl1 = 'https://localhost:44393/api/KhoanChis';
  private apiUrl = 'https://localhost:44393/api/KhoanChiMienGiams';
  constructor(private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    this.getDatas1().subscribe((data: any[]) => { this.ItemsArray = data; });
    this.reactiveForm();
  }

  onSubmit(): void {
    this.http.post<any>(this.apiUrl, this.addForm.value).subscribe(
      (data: any) => {
        alert('Post method is succeed!');
        this.document.location.href = 'http://localhost:4200/khoanchimiengiam';
      },
      error => { alert('Post method is failed!'); }
    );
  }

  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.addForm = this.builder.group({
      TenKhoanChiMienGiam: ['', [Validators.required, Validators.minLength(6)]],
      SoTienMienGiam: ['', [Validators.required]],
      IdHocSinh: ['', [Validators.required]],
      IdKhoanChi: ['', [Validators.required]],
      GhiChu: ['', ]
    });
  }

  get TenKhoanChiMienGiam(): any { return this.addForm.get('TenKhoanChiMienGiam'); }
  get SoTienMienGiam(): any { return this.addForm.get('SoTienMienGiam'); }
  get IdHocSinh(): any { return this.addForm.get('IdHocSinh'); }
  get IdKhoanChi(): any { return this.addForm.get('IdKhoanChi'); }
  get GhiChu(): any { return this.addForm.get('GhiChu'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.addForm.controls[control].hasError(error); };
}
