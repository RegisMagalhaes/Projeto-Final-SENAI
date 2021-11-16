import styles from './Cadastro.module.css'

function CadastarUsuario(e){
    e.preventdefault()
    console.log("Cadastrou")
}

function Cadastro(){
    return(
        <div className={styles.form}>
            <h1>Inscreva-se</h1>
            <form onSubmit={CadastarUsuario}>
                <div>
                    <input type='text' placeholder='Digite seu nome'/>
                </div>
                <div>
                    <input type='text' placeholder='Digite seu sobrenome'/>
                </div>
                <div>
                    <input type='text' placeholder='Digite seu CPF'/>
                </div>
                <div>
                    <input type='text' placeholder='Digite seu e-mail'/>
                </div>
                <div>
                    <input type='password' placeholder='Digite sua senha'/>
                </div>
                <div>
                    <input type='submit' value='Cadastrar'/>
                </div>
            </form>
        </div>
    )
}
export default Cadastro;