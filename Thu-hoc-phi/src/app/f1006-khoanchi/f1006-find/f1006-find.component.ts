import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { Validators, FormBuilder, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1006-find',
  templateUrl: './f1006-find.component.html',
  styleUrls: ['./f1006-find.component.scss']
})
export class F1006FindComponent implements OnInit {

  Id: number;
  editForm: FormGroup;
  ItemsArray = [];

  private apiUrl1 = 'https://localhost:44393/api/LoaiKhoanChis';
  private apiUrl = 'https://localhost:44393/api/KhoanChis';
  // tslint:disable-next-line: max-line-length
  constructor(private route: ActivatedRoute, private http: HttpClient, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    // tslint:disable-next-line: no-string-literal
    this.Id = this.route.snapshot.params['id'];
    this.getDatas1().subscribe((data: any[]) => { this.ItemsArray = data; });
    this.reactiveForm();
  }
  onSubmit(id: any): void{
    this.http.put<any>(this.apiUrl + `/${id}`, this.editForm.value).subscribe(
      (data: any) => {
        alert('Put method is succeed!');
        this.document.location.href = 'http://localhost:4200/khoanchi';
      },
      error => { alert('Put method is failed!'); }
    );
  }
  getDatas1(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl1); }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.editForm = this.builder.group({
      Id: [this.Id, ],
      TenKhoanChi: ['', [Validators.required, Validators.minLength(6)]],
      IdLoaiKhoanChi: ['', [Validators.required]],
      ThuTu: ['', ],
      SuDung: ['true']
    });
  }

  get TenKhoanChi(): any { return this.editForm.get('TenKhoanChi'); }
  get IdLoaiKhoanChi(): any { return this.editForm.get('IdLoaiKhoanChi'); }
  get ThuTu(): any { return this.editForm.get('ThuTu'); }
  get SuDung(): any { return this.editForm.get('SuDung'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.editForm.controls[control].hasError(error); };
}
