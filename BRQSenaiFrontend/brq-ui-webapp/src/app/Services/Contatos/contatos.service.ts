import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { CriarContatos, Contatos, RequestAtualizar, ResponseAtualizar } from 'src/app/Componentes/Contatos/Model/contatos.model';
import { Observable } from 'rxjs';
import { o } from "odata";

@Injectable({
    providedIn: 'root'
  })

export class ContatosService {

    private urlBrq = "http://192.168.5.34:5000/api/contatos";

    constructor(private http:HttpClient) { 

    }

    

    Cadastrar(request:CriarContatos):Observable<Contatos>{
        return this.http.post<Contatos>(this.urlBrq,request);
      }

    Atualizar(id:string,request:RequestAtualizar):Observable<ResponseAtualizar>{
    const _url = `${this.urlBrq}/${id}`;
    return this.http.put<RequestAtualizar>(_url,request);
    }


    ListarContatos(){
        return this.http.get<any[]>(this.urlBrq);
      }
    
    ListarPorId(id:string):Observable<any[]>{
    const _url = `${this.urlBrq}/${id}`;
    return this.http.get<any[]>(_url);
    }
    
    Deletar(id:string){
    const _url = `${this.urlBrq}/${id}`;
    return this.http.delete<any>(_url);
    
    }
}