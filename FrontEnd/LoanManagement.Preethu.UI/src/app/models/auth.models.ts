export interface LoginDto{
    email:string,
    password:string
}
export interface LoginResponse{
    token:string,
    userId:string,
    fullName:string,
    email:string,
    roles:string[]
}
export interface RegisterDto{
    email:string,
    password:string,
    role:string,
    fullName:string
}
export interface ChangePasswordDto{
    userId:string,
    oldPassword:string,
    newPassword:string
}