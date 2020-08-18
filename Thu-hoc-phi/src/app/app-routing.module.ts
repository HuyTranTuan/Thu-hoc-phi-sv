import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { F1001LoaikhoanthuComponent } from './f1001-loaikhoanthu/f1001-loaikhoanthu.component';
import { F1002LoaikhoanchiComponent } from './f1002-loaikhoanchi/f1002-loaikhoanchi.component';
import { F1003KhoanthucodinhComponent } from './f1003-khoanthucodinh/f1003-khoanthucodinh.component';
import { F1004KhoanthudichvuComponent } from './f1004-khoanthudichvu/f1004-khoanthudichvu.component';
import { F1005KhoanbanhangComponent } from './f1005-khoanbanhang/f1005-khoanbanhang.component';
import { F1006KhoanchiComponent } from './f1006-khoanchi/f1006-khoanchi.component';
import { F1007KhoanchimiengiamComponent } from './f1007-khoanchimiengiam/f1007-khoanchimiengiam.component';
import { F5002DanhsachphieuthuComponent } from './f5002-danhsachphieuthu/f5002-danhsachphieuthu.component';
// child
import { WelcomeComponent } from './welcome/welcome.component';
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
import { F2001QldangkydichvuComponent } from './f2001-qldangkydichvu/f2001-qldangkydichvu.component';
import { F2001AddComponent } from './f2001-qldangkydichvu/f2001-add/f2001-add.component';
import { F5002DetailComponent } from './f5002-danhsachphieuthu/f5002-detail/f5002-detail.component';
import { F5001BaocaocongnohocsinhComponent } from './f5001-baocaocongnohocsinh/f5001-baocaocongnohocsinh.component';
import { F5003BaocaodangkidicvuComponent } from './f5003-baocaodangkidicvu/f5003-baocaodangkidicvu.component';
import { F4001LapkehoachthuComponent } from './f4001-lapkehoachthu/f4001-lapkehoachthu.component';
import { F4003ThuhocphiComponent } from './f4003-thuhocphi/f4003-thuhocphi.component';
import { F4003AddprodsComponent } from './f4003-thuhocphi/f4003-addprods/f4003-addprods.component';
import { F4003AddrefundComponent } from './f4003-thuhocphi/f4003-addrefund/f4003-addrefund.component';
import { F4001AddComponent } from './f4001-lapkehoachthu/f4001-add/f4001-add.component';
import { F4001DodukienhocsinhComponent } from './f4001-lapkehoachthu/f4001-dodukienhocsinh/f4001-dodukienhocsinh.component';
import { F4003DetailComponent } from './f4003-thuhocphi/f4003-detail/f4003-detail.component';
import { F2001EditComponent } from './f2001-qldangkydichvu/f2001-edit/f2001-edit.component';
import { F4001EditComponent } from './f4001-lapkehoachthu/f4001-edit/f4001-edit.component';



const routes: Routes = [
  { path: '', component: WelcomeComponent , pathMatch: 'full'},

  // f1001 Loai khoan thu
  { path: 'loaikhoanthu', component: F1001LoaikhoanthuComponent},
  { path: 'loaikhoanthu/add', component: F1001AddComponent},
  { path: 'loaikhoanthu/put/:id', component: F1001FindComponent},

  // f1002 Loai khoan chi
  { path: 'loaikhoanchi', component: F1002LoaikhoanchiComponent },
  { path: 'loaikhoanchi/add', component: F1002AddComponent },
  { path: 'loaikhoanchi/put/:id', component: F1002FindComponent },

  // f1003 Khoan thu co dinh
  { path: 'khoanthucodinh', component: F1003KhoanthucodinhComponent},
  { path: 'khoanthucodinh/add', component: F1003AddComponent },
  { path: 'khoanthucodinh/put/:id', component: F1003FindComponent },

  // f1004 Khoan thu dich vu
  { path: 'khoanthudichvu', component: F1004KhoanthudichvuComponent},
  { path: 'khoanthudichvu/add', component: F1004AddComponent },
  { path: 'khoanthudichvu/put/:id', component: F1004FindComponent },

  // f1005 Khoan ban hang
  { path: 'khoanbanhang', component: F1005KhoanbanhangComponent},
  { path: 'khoanbanhang/add', component: F1005AddComponent },
  { path: 'khoanbanhang/put/:id', component: F1005FindComponent },

  // f1006 Khoan chi
  { path: 'khoanchi', component: F1006KhoanchiComponent},
  { path: 'khoanchi/add', component: F1006AddComponent },
  { path: 'khoanchi/put/:id', component: F1006FindComponent },

  // f1007 Khoan chi mien giam
  { path: 'khoanchimiengiam', component: F1007KhoanchimiengiamComponent},
  { path: 'khoanchimiengiam/add', component: F1007AddComponent },
  { path: 'khoanchimiengiam/groupadd', component: F1007GroupaddComponent },
  { path: 'khoanchimiengiam/put/:id', component: F1007FindComponent },

  // f2001 Quan ly dang ki dich vu
  { path: 'quanlydangkydichvu', component: F2001QldangkydichvuComponent },
  { path: 'quanlydangkydichvu/add', component: F2001AddComponent },
  { path: 'quanlydangkydichvu/put/:id', component: F2001EditComponent },

  // f4001 Lap ke hoach thu
  { path: 'lapkehoachthu', component: F4001LapkehoachthuComponent },
  { path: 'lapkehoachthu/add', component: F4001AddComponent },
  { path: 'lapkehoachthu/dodukien', component: F4001DodukienhocsinhComponent },
  { path: 'lapkehoachthu/put/:id', component: F4001EditComponent },

  // f4003 Thu hoc phi
  { path: 'thuhocphi', component: F4003ThuhocphiComponent },
  { path: 'thuhocphi/addprods', component: F4003AddprodsComponent },
  { path: 'thuhocphi/addrefund', component: F4003AddrefundComponent },
  { path: 'thuhocphi/detail/:id', component: F4003DetailComponent },

  // f5002 Danh sach phieu thu
  { path: 'danhsachphieuthu', component: F5002DanhsachphieuthuComponent},
  { path: 'danhsachphieuthu/detail/:id', component: F5002DetailComponent },

  // f5001 Bao cao cong no hoc sinh
  { path: 'baocaocongnohocsinh', component: F5001BaocaocongnohocsinhComponent },

  // f5003 Bao cao dang ki dich vu
  { path: 'baocaodangkidichvu', component: F5003BaocaodangkidicvuComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
