import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormControl, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1002-find',
  templateUrl: './f1002-find.component.html',
  styleUrls: ['./f1002-find.component.scss']
})
export class F1002FindComponent implements OnInit {

  Id: number;
  editForm: FormGroup;

  private apiUrl = 'https://localhost:44393/api/LoaiKhoanChis';
  // tslint:disable-next-line: max-line-length
  constructor(private http: HttpClient, private route: ActivatedRoute, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    // tslint:disable-next-line: no-string-literal
    this.Id = this.route.snapshot.params['id'];
    this.reactiveForm();
  }

  // tslint:disable-next-line: typedef
  onSubmit(id: any){
    this.http.put<any>(this.apiUrl + `/${id}`, this.editForm.value).subscribe(
      (data: any) =>  {
        alert('Put method is succeed!');
        this.document.location.href = 'http://localhost:4200/loaikhoanchi';
      },
      error => { alert('Put method is failed!'); }
    );
  }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.editForm = this.builder.group({
      Id: [this.Id, ],
      TenLoaiKhoanChi: ['', [Validators.required, Validators.minLength(6)]],
      ThuTu: ['', ],
      SuDung: ['true']
    });
  }
  get TenLoaiKhoanChi(): any { return this.editForm.get('TenLoaiKhoanChi'); }
  get ThuTu(): any { return this.editForm.get('ThuTu'); }
  get SuDung(): any { return this.editForm.get('SuDung'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.editForm.controls[control].hasError(error); };
}
