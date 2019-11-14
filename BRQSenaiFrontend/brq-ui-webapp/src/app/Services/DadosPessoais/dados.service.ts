import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { CriarDados, Dados, RequestAtualizar, ResponseAtualizar, ListaNome, RequestLogin, ResponseLogin } from 'src/app/Componentes/DadosPessoais/Model/dadospessoais.model';
import { Observable } from 'rxjs';
import { o } from "odata";

@Injectable({
  providedIn: 'root'
})
export class DadosService {
  lista:Array<any>
  Lista:Observable<any>;
  
  private url = "http://5d7bcea76b8ef80014b29752.mockapi.io/api/brq/users";
  private urlBrq = "http://192.168.5.34:5000/api/pessoas";
  //private urlBrq = "https://brqhrtcolaboradoreswebapi20191031025543.azurewebsites.net/";
  

  constructor(private http:HttpClient) { 

  }
  
  listar(){
     
    const response = o(this.urlBrq)
    .get()
    .query();
 }
  Cadastrar(request:CriarDados):Observable<Dados>{
    return this.http.post<CriarDados>(this.urlBrq,request);
  }
  Atualizar(id:string,request:RequestAtualizar):Observable<ResponseAtualizar>{
    const _url = `${this.urlBrq}/${id}`;
    return this.http.put<RequestAtualizar>(_url,request);
  }
  listarPorId(id:string):Observable<Dados>{
    const _url = `${this.urlBrq}/${id}`;
    return this.http.get<Dados>(_url);
  }
  listarNome(id:string):Observable<ListaNome>{
    const _url = `${this.urlBrq}/${id}`;
    return this.http.get<ListaNome>(_url);
  }
  listarPorFiltro(filtro:string):Observable<any[]>{
    const _url = `${this.urlBrq}/${filtro}`;
    return this.http.get<any[]>(_url);
  }
 
}