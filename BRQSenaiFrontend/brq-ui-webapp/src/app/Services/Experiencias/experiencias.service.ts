import { Injectable,EventEmitter } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RequestAtualizar, ResponseAtualizar } from 'src/app/Componentes/DadosPessoais/Model/dadospessoais.model';
import { Experiencias, Base } from 'src/app/Componentes/Experiencias/Model/experiencias.model';
import { Observable } from 'rxjs';
import { MatDialogConfig, MatDialog } from '@angular/material/dialog';
import { DeletarExperienciaComponent } from 'src/app/Componentes/Experiencias/deletar-experiencia/deletar-experiencia.component';

@Injectable({
  providedIn: 'root'
})
export class ExperienciasService {
  emitirID = new EventEmitter<string>();
  private url = "http://5d7bcea76b8ef80014b29752.mockapi.io/api/brq/experiencias";
  constructor(private http:HttpClient,private dialog: MatDialog) { 

  }
  // Cadastrar(request:CriarExperiencias):Observable<Experiencias>{
  //   return this.http.post<CriarExperiencias>(this.url,request);
  // }
  
  Atualizar(idExperiencia:string,request:Array<any>):Observable<any[]>{
    const _url = `${this.url}/${idExperiencia}`;
    return this.http.put<any[]>(_url,request);
  }
  
  ListarTodas(){
    return this.http.get<any[]>(this.url);
  }
  
  ListarPorId(idExperiencia:string):Observable<Experiencias>{
    const _url = `${this.url}/${idExperiencia}`;
    return this.http.get<Experiencias>(_url);
  }
  Deletar(idExperiencia:string){
    const _url = `${this.url}/${idExperiencia}`;
    return this.http.delete<any>(_url);
  }
  

}
