import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { CriarHabilidades, Habilidades, RequestAtualizar, ResponseAtualizar } from 'src/app/Componentes/Habilidades/Model/habilidades.model';
@Injectable({
  providedIn: 'root'
})
export class SkillService {
  private url = "http://5d7bcea76b8ef80014b29752.mockapi.io/api/brq/skill";
  constructor(private http:HttpClient) { 

  }
  
  Cadastrar(request:CriarHabilidades):Observable<Habilidades>{
    return this.http.post<CriarHabilidades>(this.url,request);
  }
  
  Atualizar(idSkill:string,request:RequestAtualizar):Observable<ResponseAtualizar>{
    const _url = `${this.url}/${idSkill}`;
    return this.http.put<RequestAtualizar>(_url,request);
  }
  
  ListarTodas(){
    return this.http.get<any[]>(this.url);
  }

  ListarPorId(idSkill:string):Observable<any[]>{
    const _url = `${this.url}/${idSkill}`;
    return this.http.get<any[]>(_url);
  }
  Deletar(idSkill:string){
    const _url = `${this.url}/${idSkill}`;
    return this.http.delete<any>(_url);
    
  }
}
