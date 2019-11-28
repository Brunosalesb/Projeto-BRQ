export class Services {
    base_url="http://192.168.5.34:5000/api";
API(){
    const url = `${this.base_url}/pessoas/todosdados`;
    return url;
}
APIPessoas(){
    const url =`${this.base_url}/pessoas`;
    return url;
}
APISkill(){
    const url = `${this.base_url}/Skills`;
    return url;
}
APITipoSkill(){
    const url = `${this.base_url}/TipoSkills`;
    return url;
}
ApiLogin(){
    const url = `${this.base_url}/login`;
    return url;
}
APIExperiencia(){
    const url = `${this.base_url}/Experiencias`;
    return url;
}
APITipoExperiencia(){
    const url = `${this.base_url}/TipoExperiencias`;
    return url;
}
APIVagas(){
    const url =  "http://5db73fd7e2c76f0014a53cc3.mockapi.io/api/vagas"
    return url;
};

}

// url api brq
"http://192.168.5.34:5000/api/pessoas/todosdados"
// url api mockapi
"http://5d7bcea76b8ef80014b29752.mockapi.io/api/brq/users"