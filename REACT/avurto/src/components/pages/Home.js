import styles from './Home.module.css'
import img1 from '../../img/img1.png'

function Home(){
    return(
        <section className={styles.home_container}>
            <div>
            <h1>Bem Vindo a <span>Avurto Treinamentos</span></h1>
            <p>Aprenda a desenvolver e gerenciar aplicações agora mesmo!</p>
            <a href='./'>Começar</a>

            </div>
            <div>
            <img src={img1} alt='imagem do computador'/>
            </div>
        </section>
    )
}
export default Home;