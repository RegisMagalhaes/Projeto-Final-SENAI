import styles from './Cursos.module.css'
import Card from '../layout/Card'
import imgcard from '../../img/imgcard.png'
import img1 from '../../img/img1.png'





function Cursos(){
    return(
       <div className="wrapper">
           <Card  imagem= {imgcard} titulo='Card1' descricao='O Regis é um excelente desenvolvedor'/>
           <Card imagem= {img1} titulo='titulo2' descricao='O Matheus é um excelente desenvolvedor'/>
           <Card  imagem= {imgcard} titulo='Card1' descricao='O Bruno é um excelente desenvolvedor'/>
       </div>
    )
}
export default Cursos;
