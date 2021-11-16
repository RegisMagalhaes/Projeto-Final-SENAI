import styles from './Login.module.css'

function LogarUsuario(e){
    e.preventdefault()
    console.log("Logou")
}

function Login(){
    return(
        <section className={styles.form}>

        <div>
            <h1>Login</h1>
            <form onSubmit={LogarUsuario} className={styles.form}>              
                <div className={styles.item}>
                    <input type='text' placeholder='Digite seu e-mail'/>
                </div>
                <div className={styles.item}>
                    <input type='password' placeholder='Digite sua senha'/>
                </div>
                <div className={styles.item}>
                    <input type='submit' value='Login'/>
                </div>
            </form>
        </div>

        </section>
    )
}
export default Login;