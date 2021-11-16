import {Link} from 'react-router-dom'
import Container from './Container';
import styles from './Navbar.module.css'
import logo1 from '../../img/logo1.png'

function Navbar(){
    return(
        <nav className={styles.navbar}>
            <Container>
                <Link className={styles.item} to='/'>
                    <img src={logo1} alt="logo da Avurto"/>
                </Link>
               <ul className={styles.list}>
                   <li className={styles.item}><Link to='/'>Home</Link></li>
                   <li className={styles.item}><Link to='/cursos'>Cursos</Link></li>
                   <li className={styles.item}><Link to='/login'>Login</Link></li>
                   <li className={styles.item}><Link to='/cadastro'>Cadastro</Link></li>  
               </ul>
            </Container>
        </nav>
    )
}
export default Navbar;