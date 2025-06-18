import { Component } from "@angular/core";
import { LoginComponent } from "./login.component"
import { ComponentFixture, TestBed } from "@angular/core/testing";
import { FormsModule } from "@angular/forms";
import { AuthService } from "../services/auth.service";
import { Router } from "@angular/router";

class MockAuthService{
    login(token:string){
        localStorage.setItem('token',token);
    }
}
class MockRouter{
    navigateByUrl=jasmine.createSpy('navigateByUrl');
}

describe('LoginComponent',()=>{
    let component:LoginComponent;
    let fixture:ComponentFixture<LoginComponent>;
    let router:MockRouter;

    beforeEach(()=>{

        TestBed.configureTestingModule({
            declarations:[LoginComponent],
            imports:[FormsModule],
            providers:[
                {provide:AuthService,useClass:MockAuthService},
                {provide:Router,useClass:MockRouter}
            ]
        }).compileComponents();

        fixture=TestBed.createComponent(LoginComponent);
        component=fixture.componentInstance;
        router=TestBed.inject(Router) as unknown as MockRouter;
    });

    it('should create',()=>{
        expect(component).toBeTruthy();
    });


    it('shpuld login successfully with correct credetials',()=>{
        component.username='user',
        component.password='pass',
        component.login();

        expect(localStorage.getItem('token')).toBe('sample-token');
        expect(component.error).toBe('');
    });
})