import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MatNativeDateModule } from '@angular/material/core';
import { NgxPrintModule } from 'ngx-print';
import { CommonModule } from '@angular/common';

// tslint:disable-next-line: comment-format
//Material
import { MatIconModule } from '@angular/material/icon';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatButtonModule } from '@angular/material/button';
import { MatBadgeModule } from '@angular/material/badge';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatInputModule } from '@angular/material/input';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSelectModule } from '@angular/material/select';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatRadioModule } from '@angular/material/radio';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatChipsModule } from '@angular/material/chips';
import { MAT_FORM_FIELD_DEFAULT_OPTIONS, MatFormFieldModule } from '@angular/material/form-field';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { F1001LoaikhoanthuComponent } from './f1001-loaikhoanthu/f1001-loaikhoanthu.component';
import { F1002LoaikhoanchiComponent } from './f1002-loaikhoanchi/f1002-loaikhoanchi.component';
import { F1003KhoanthucodinhComponent } from './f1003-khoanthucodinh/f1003-khoanthucodinh.component';
import { F1004KhoanthudichvuComponent } from './f1004-khoanthudichvu/f1004-khoanthudichvu.component';
import { F1005KhoanbanhangComponent } from './f1005-khoanbanhang/f1005-khoanbanhang.component';
import { F1006KhoanchiComponent } from './f1006-khoanchi/f1006-khoanchi.component';
import { F1007KhoanchimiengiamComponent } from './f1007-khoanchimiengiam/f1007-khoanchimiengiam.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { F1001AddComponent } from './f1001-loaikhoanthu/f1001-add/f1001-add.component';
import { F1001FindComponent } from './f1001-loaikhoanthu/f1001-find/f1001-find.component';
import { F1002FindComponent } from './f1002-loaikhoanchi/f1002-find/f1002-find.component';
import { F1002AddComponent } from './f1002-loaikhoanchi/f1002-add/f1002-add.component';
import { F1003FindComponent } from './f1003-khoanthucodinh/f1003-find/f1003-find.component';
import { F1003AddComponent } from './f1003-khoanthucodinh/f1003-add/f1003-add.component';
import { F1004FindComponent } from './f1004-khoanthudichvu/f1004-find/f1004-find.component';
import { F1004AddComponent } from './f1004-khoanthudichvu/f1004-add/f1004-add.component';
import { F1005FindComponent } from './f1005-khoanbanhang/f1005-find/f1005-find.component';
import { F1005AddComponent } from './f1005-khoanbanhang/f1005-add/f1005-add.component';
import { F1006FindComponent } from './f1006-khoanchi/f1006-find/f1006-find.component';
import { F1006AddComponent } from './f1006-khoanchi/f1006-add/f1006-add.component';
import { F1007FindComponent } from './f1007-khoanchimiengiam/f1007-find/f1007-find.component';
import { F1007AddComponent } from './f1007-khoanchimiengiam/f1007-add/f1007-add.component';
import { F1007GroupaddComponent } from './f1007-khoanchimiengiam/f1007-groupadd/f1007-groupadd.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { F2001QldangkydichvuComponent } from './f2001-qldangkydichvu/f2001-qldangkydichvu.component';
import { F5002DanhsachphieuthuComponent } from './f5002-danhsachphieuthu/f5002-danhsachphieuthu.component';
import { F5002DetailComponent } from './f5002-danhsachphieuthu/f5002-detail/f5002-detail.component';
import { F5001BaocaocongnohocsinhComponent } from './f5001-baocaocongnohocsinh/f5001-baocaocongnohocsinh.component';
import { F5003BaocaodangkidicvuComponent } from './f5003-baocaodangkidicvu/f5003-baocaodangkidicvu.component';
import { F4001LapkehoachthuComponent } from './f4001-lapkehoachthu/f4001-lapkehoachthu.component';
import { F4003ThuhocphiComponent } from './f4003-thuhocphi/f4003-thuhocphi.component';
import { F4001AddComponent } from './f4001-lapkehoachthu/f4001-add/f4001-add.component';
import { F4001DodukienhocsinhComponent } from './f4001-lapkehoachthu/f4001-dodukienhocsinh/f4001-dodukienhocsinh.component';
import { F4003AddprodsComponent } from './f4003-thuhocphi/f4003-addprods/f4003-addprods.component';
import { F4003AddrefundComponent } from './f4003-thuhocphi/f4003-addrefund/f4003-addrefund.component';
import { F2001AddComponent } from './f2001-qldangkydichvu/f2001-add/f2001-add.component';
import { F4003DetailComponent } from './f4003-thuhocphi/f4003-detail/f4003-detail.component';
import { F2001EditComponent } from './f2001-qldangkydichvu/f2001-edit/f2001-edit.component';
import { F4001EditComponent } from './f4001-lapkehoachthu/f4001-edit/f4001-edit.component';


@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    F1001LoaikhoanthuComponent,
    F1002LoaikhoanchiComponent,
    F1003KhoanthucodinhComponent,
    F1004KhoanthudichvuComponent,
    F1005KhoanbanhangComponent,
    F1006KhoanchiComponent,
    F1007KhoanchimiengiamComponent,
    F1001AddComponent,
    F1001FindComponent,
    F1002FindComponent,
    F1002AddComponent,
    F1003FindComponent,
    F1003AddComponent,
    F1004FindComponent,
    F1004AddComponent,
    F1005FindComponent,
    F1005AddComponent,
    F1006FindComponent,
    F1006AddComponent,
    F1007FindComponent,
    F1007AddComponent,
    F1007GroupaddComponent,
    F2001QldangkydichvuComponent,
    F5002DanhsachphieuthuComponent,
    F5001BaocaocongnohocsinhComponent,
    F5002DetailComponent,
    F5003BaocaodangkidicvuComponent,
    F4001LapkehoachthuComponent,
    F4003ThuhocphiComponent,
    F4001AddComponent,
    F4001DodukienhocsinhComponent,
    F4003AddprodsComponent,
    F4003AddrefundComponent,
    F2001AddComponent,
    F4003DetailComponent,
    F2001EditComponent,
    F4001EditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatNativeDateModule,
    NgxPrintModule,
    CommonModule,

    BrowserAnimationsModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
    MatButtonModule,
    MatBadgeModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatInputModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatSelectModule,
    MatCheckboxModule,
    MatRadioModule,
    MatDatepickerModule,
    MatTooltipModule,
    MatGridListModule,
    MatChipsModule
  ],
  exports: [
    MatButtonModule,
    MatToolbarModule,
    MatIconModule,
    MatSidenavModule,
    MatBadgeModule,
    MatListModule,
    MatGridListModule,
    MatInputModule,
    MatFormFieldModule,
    MatSelectModule,
    MatRadioModule,
    MatDatepickerModule,
    MatChipsModule,
    MatTooltipModule,
    MatTableModule,
    MatPaginatorModule
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ],
  providers: [{provide: MAT_FORM_FIELD_DEFAULT_OPTIONS, useValue: {floatLabel: 'always'}}, MatDatepickerModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
