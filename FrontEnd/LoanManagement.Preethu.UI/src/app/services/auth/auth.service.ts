import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {
  LoginDto,
  LoginResponse,
  RegisterDto,
  ChangePasswordDto
} from '../../models/auth.models';

@Injectable({
  providedIn: 'root',
})
export class AuthService {

  private apiUrl = 'https://localhost:7044/api/auth';

  constructor(private http: HttpClient) {}

  login(dto: LoginDto): Observable<LoginResponse> {
    return this.http.post<LoginResponse>(`${this.apiUrl}/login`, dto);
  }
  register(dto: RegisterDto): Observable<any> {
    return this.http.post(`${this.apiUrl}/register`, dto);
  }
  changePassword(dto: ChangePasswordDto): Observable<any> {
    return this.http.post(`${this.apiUrl}/change-password`, dto);
  }
  saveToken(token: string) {
    localStorage.setItem('accessToken', token);
  }
  getToken(): string | null {
    return localStorage.getItem('accessToken');
  }
  saveUserId(id: string) {
    localStorage.setItem('userId', id);
  }
  getUserId(): string | null {
    return localStorage.getItem('userId');
  }
  logout() {
    localStorage.removeItem('accessToken');
    localStorage.removeItem('userId');
  }
  isLoggedIn(): boolean {
    return !!this.getToken();
  }
}
