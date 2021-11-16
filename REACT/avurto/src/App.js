import {BrowserRouter as Router, Switch, Route, Link} from 'react-router-dom'
import Home from './components/pages/Home'
import Cursos from './components/pages/Cursos'
import Login from './components/pages/Login'
import Cadastro from './components/pages/Cadastro'

import Container from './components/layout/Container'
import Navbar from './components/layout/Navbar'
import Footer from './components/layout/Footer'




function App() {
  return (
    <Router>
      <Navbar/>
      <Switch>
        <Container customClass="min_height">
          <Route exact path='/'>
            <Home/>
          </Route>
          <Route exact path='/cursos'>
            <Cursos/>
          </Route>
          <Route exact path='/login'>
            <Login/>
          </Route>
          <Route exact path='/cadastro'>
            <Cadastro/>
          </Route>
        </Container>
      </Switch>
      <Footer/>
    </Router>
  );
}

export default App;
