import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: 'shop',
    loadChildren: () =>
      import('../modules/shop/shop.module').then((m) => m.ShopModule),
  },
  {
    path: 'login',
    loadChildren: () =>
      import('../modules/auth/auth.module').then((m) => m.AuthModule),
  },
  { path: '', redirectTo: '/shop', pathMatch: 'full' },
  { path: '**', redirectTo: '/shop' },
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
