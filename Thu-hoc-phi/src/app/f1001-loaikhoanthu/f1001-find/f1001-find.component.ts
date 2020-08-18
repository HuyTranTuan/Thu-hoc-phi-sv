import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { Validators, FormBuilder, FormControl, FormGroup  } from '@angular/forms';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-f1001-find',
  templateUrl: './f1001-find.component.html',
  styleUrls: ['./f1001-find.component.scss']
})
export class F1001FindComponent implements OnInit {

  Id: number;
  editForm: FormGroup;
  ItemsArray = [];

  private apiUrl2 = 'https://localhost:44393/api/TinhChatKhoanThus';
  private apiUrl = 'https://localhost:44393/api/LoaiKhoanThus';
  // tslint:disable-next-line: max-line-length
  constructor(private http: HttpClient, private route: ActivatedRoute, private builder: FormBuilder, @Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    // tslint:disable-next-line: no-string-literal
    this.Id = this.route.snapshot.params['id'];
    this.getDatas().subscribe((data: any[]) => { this.ItemsArray = data; });
    this.reactiveForm();
  }

  // tslint:disable-next-line: typedef
  onSubmit(id: any){
    this.http.put<any>(this.apiUrl + `/${id}`, this.editForm.value).subscribe(
      (data: any) =>  {
        alert('Put method is succeed!');
        this.document.location.href = 'http://localhost:4200/loaikhoanthu';
      },
      error => { alert('Put method is failed!'); }
    );
  }
  // tslint:disable-next-line: typedef
  reactiveForm() {
    this.editForm = this.builder.group({
      Id: [this.Id, ],
      TenLoaiKhoanThu: ['', [Validators.required, Validators.minLength(6)]],
      IdTinhChatKhoanThu: ['', [Validators.required]],
      ThuTu: ['', ],
      SuDung: ['true']
    });
  }
  getDatas(): Observable<any[]> { return this.http.get<any[]>(this.apiUrl2); }
  get TenLoaiKhoanThu(): any { return this.editForm.get('TenLoaiKhoanThu'); }
  get IdTinhChatKhoanThu(): any { return this.editForm.get('IdTinhChatKhoanThu'); }
  get ThuTu(): any { return this.editForm.get('ThuTu'); }
  get SuDung(): any { return this.editForm.get('SuDung'); }
  // tslint:disable-next-line: arrow-return-shorthand
  public errorHandling = (control: string, error: string) => { return this.editForm.controls[control].hasError(error); };
}
