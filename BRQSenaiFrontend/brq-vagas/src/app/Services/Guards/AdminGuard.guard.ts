import { CanActivate, ActivatedRoute, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Injectable } from '@angular/core';
import { LoginService } from '../Login/login.service';
import { Observable } from 'rxjs';


@Injectable()
export class AdminGuardService implements CanActivate{

  constructor(private service:LoginService,private router:Router) {

   }
   canActivate(
    route:ActivatedRouteSnapshot,
    state:RouterStateSnapshot,
   ):Observable<boolean> | boolean{
    if (this.service.Autorizado()) {
        
        return true;
    }
    else{
      
      this.router.navigate(['']);
      return false;
    }
   }
}