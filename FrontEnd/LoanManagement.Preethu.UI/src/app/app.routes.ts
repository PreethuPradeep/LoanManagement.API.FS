import { Routes } from '@angular/router';
import { Home } from './components/dashboard/home/home';
import { Login } from './components/auth/login/login';
import { Register } from './components/auth/register/register';
import { NotFound } from './components/shared/not-found/not-found';
import { ChangePassword } from './components/auth/change-password/change-password';
import { authGuard } from './core/auth.guard';

export const routes: Routes = [
    { path: '', component: Home ,canActivate: [authGuard]},
    { path: 'login', component: Login },
    { path: 'register', component: Register },
    { path: 'change-password', component: ChangePassword},

    { path: '**', component: NotFound }
];
