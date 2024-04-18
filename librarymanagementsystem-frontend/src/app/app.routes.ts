import { Routes } from '@angular/router';
import { HomepageComponent } from './shared/pages/homepage/homepage.component';
import { authGuard } from './core/guards/auth.guard';
import { AuthComponent } from './features/auth/pages/auth/auth.component';
import { AdminLayoutComponent } from './shared/layouts/admin-layout/admin-layout.component';
import { DashboardComponent } from './features/pages/dashboard/dashboard.component';
import { MaterialComponent } from './features/pages/material/material.component';
import { UserComponent } from './features/pages/user/user.component';
import { BranchComponent } from './features/pages/branch/branch.component';

export const routes: Routes = [
  { path: '', redirectTo: 'adminpage', pathMatch: 'full' },
  // { path: 'homepage', component: HomepageComponent },
  // { path: 'homepage', component: AdminLayoutComponent },

  // { path: 'adminpage', component: AdminLayoutComponent, canActivate: [authGuard] },
  { 
    path: 'adminpage',
    component: AdminLayoutComponent,
    // canActivate: [authGuard],
    children: [
      { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
      { path: 'dashboard', component: DashboardComponent },
      { path: 'materials', component: MaterialComponent },
      { path: 'users', component: UserComponent },
      {path: 'branches', component:BranchComponent},
    ]
  }
];
