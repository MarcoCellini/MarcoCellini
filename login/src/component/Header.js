import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import IconButton from '@mui/material/IconButton';
import MenuIcon from '@mui/icons-material/Menu';
import AccountCircle from '@mui/icons-material/AccountCircle';
import Menu from '@mui/material/Menu';

import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemText from '@mui/material/ListItemText';
import ExpandLess from '@mui/icons-material/ExpandLess';
import ExpandMore from '@mui/icons-material/ExpandMore';
import Collapse from '@mui/material/Collapse';

import { useNavigate } from "react-router-dom";

export default function MenuAppBar() {
  
  let navigate = useNavigate();

  const [anchorEl, setAnchorEl] = React.useState(null);
  const [openNested, setOpenNested] = React.useState(null);
  const [anchorEl2, setAnchorEl2] = React.useState(null); 

  const clickRightMenu = (event) => {
    setAnchorEl(event.currentTarget);
  };

  const clickFeatures = () => {
      setOpenNested(!openNested);
  };

  const handleClose = () => {
    setAnchorEl(null);
  };

  const clickLeftMenu = event => {
    setOpenNested(false); 
    setAnchorEl2(event.currentTarget);
  };

  /* routePaths are defined in App.js */
  const redirectRoute = routePath => {
    navigate(routePath);
    setAnchorEl(null);
  };


  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static">
        <Toolbar>
          <IconButton
            size="large"
            edge="start"
            color="inherit"
            aria-label="menu"
            sx={{ mr: 2 }}
            onClick={clickLeftMenu}
          >
            <MenuIcon />
          </IconButton>

          <Menu
            id="menu-appbar"
            anchorEl={anchorEl2}
            open={Boolean(anchorEl2)}
            onClose={() => {setAnchorEl2(null);setOpenNested(true);}}>
            <List
                component="nav"
                aria-labelledby="nested-list-subheader"
              >
                <ListItem button onClick={() => redirectRoute("/home")}>
                  <ListItemText primary="Home" />
                </ListItem>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Anagrafica" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/Anagrafica/clienti_fornitori_vettori")}>
                      <ListItemText primary="Clienti / Fornitori / Vettori" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Anagrafica/Articoli")}>
                      <ListItemText primary="Articoli" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>
                
                <ListItem button  onClick={() => redirectRoute("/Anagrafica")}>
                  <ListItemText primary="Anagrafica" />
                </ListItem>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Ordini fornitori" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/OrdiniFornitori/Ordini")}>
                      <ListItemText primary="Ordini" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniFornitori/Avanzamento")}>
                      <ListItemText primary="Avanzamento" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniFornitori/GenerazioneLotti")}>
                      <ListItemText primary="Generazione Lotti" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniFornitori/NoteFornitore")}>
                      <ListItemText primary="Note ordini fornitori" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniFornitori/NoteTrasporto")}>
                      <ListItemText primary="Note ordini servizio trasporto" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniFornitori/ReportFornitori")}>
                      <ListItemText primary="Report fornitori" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniFornitori/ReportPrevisionale")}>
                      <ListItemText primary="Report previsionale fatture fornitori" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Ordini clienti" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/OrdiniClienti/OrdiniListino")}>
                      <ListItemText primary="Ordini da listino" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniClienti/Ordini")}>
                      <ListItemText primary="Ordini" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniClienti/Avanzamento")}>
                      <ListItemText primary="Avanzamento" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniClienti/Scarico")}>
                      <ListItemText primary="Scarico" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniClienti/NoteOrdine")}>
                      <ListItemText primary="Note Ordini" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/OrdiniClienti/ReportClienti")}>
                      <ListItemText primary="Report Clienti" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Lotti" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/Lotti/Gestione")}>
                      <ListItemText primary="Gestione" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Lotti/ReportLotti")}>
                      <ListItemText primary="Report lotti" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Lotti/AggiornamentoExcel")}>
                      <ListItemText primary="Aggiornamento da Excel" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Movimenti di magazzino" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/MovimentoMagazzino/Gestione")}>
                      <ListItemText primary="Gestione" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/MovimentoMagazzino/Report")}>
                      <ListItemText primary="Report DDT/Trasporti " />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Documenti di trasporto" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/DocTrasporto/Esportazione")}>
                      <ListItemText primary="Esportazione vs. sistemi" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Report Generali" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/ReportGenerale/Elenco")}>
                      <ListItemText primary="Elenco" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Conto lavorazione a fornitore" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/ContoFornitore/CompilazioneDDT")}>
                      <ListItemText primary="Compilazione DTT" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/ContoFornitore/RicevimentoMerce")}>
                      <ListItemText primary="Ricevimento merci" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/ContoFornitore/altro")}>
                      <ListItemText primary="..." />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Conto lavorazione da cliente" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/ContoCliente/InsOrdine")}>
                      <ListItemText primary="Inserimento ordine" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/ContoCliente/AvanOrdine")}>
                      <ListItemText primary="Avanzamento ordine" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/ContoCliente/altro")}>
                      <ListItemText primary="..." />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Prodotti & Formule" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/Prod&Form/Prodotti")}>
                      <ListItemText primary="Prodotti" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Prod&Form/Tecnologie")}>
                      <ListItemText primary="Tecnologie" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Prod&Form/QuotazioneMP-ADD-COL")}>
                      <ListItemText primary="Quotazione M.P., ADD., COL." />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Prod&Form/QuotazioniTech")}>
                      <ListItemText primary="Quotazioni tecnologie" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Prod&Form/QuotazioneLavorazioni")}>
                      <ListItemText primary="Quotazione lavorazioni" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Prod&Form/Formule")}>
                      <ListItemText primary="Formule" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Prod&Form/Margine")}>
                      <ListItemText primary="Margine" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Listino clienti" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/ListinoClienti/Gestione")}>
                      <ListItemText primary="Gestione" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/ListinoClienti/ConfEmail")}>
                      <ListItemText primary="Configurazione email" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Inventario" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/Inventario/Report")}>
                      <ListItemText primary="Report" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Abilitazioni" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/Abilitazioni/Predefinite")}>
                      <ListItemText primary="Report" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/Abilitazioni/Operatore")}>
                      <ListItemText primary="Report" />
                      <hr />
                    </ListItem>
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Tabelle di servizio" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/Provincia")}>
                      <ListItemText primary="Provincia" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/Nazione")}>
                      <ListItemText primary="Report" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/ModPagamento")}>
                      <ListItemText primary="Modalità di pagamento" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/BloccoAnagrafiche")}>
                      <ListItemText primary="Causali blocco anagrafiche" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/TipoPorto")}>
                      <ListItemText primary="Tipo porto" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/CausaliTrasporto")}>
                      <ListItemText primary="Causali di trasporto" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/TipoTrasporto")}>
                      <ListItemText primary="Tipo di trasporto" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/Unita")}>
                      <ListItemText primary="Unità di misura" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/Colori")}>
                      <ListItemText primary="Colori" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/AspettoBeni")}>
                      <ListItemText primary="Aspetto beni trasportati" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/MatImaballo")}>
                      <ListItemText primary="Materiale imballo / confezione" />
                    </ListItem>
                  <ListItem button onClick={() => redirectRoute("/TabServizio/TipoImballo")}>
                      <ListItemText primary="Tipo imballo / confezione" />
                    </ListItem>
                    <hr />
                  </List>
                </Collapse>

                <ListItem button  onClick={() => redirectRoute("/Azienda")}>
                  <ListItemText primary="Azienda" />
                </ListItem>

                <ListItem button  onClick={() => redirectRoute("/Attivita")}>
                  <ListItemText primary="Attività" />
                </ListItem>

                <ListItem button  onClick={() => redirectRoute("/Operatori")}>
                  <ListItemText primary="Operatori" />
                </ListItem>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Magazzino fiscale" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                  <ListItem button onClick={() => redirectRoute("/MagazzinoFiscale/Genera&Stampa")}>
                      <ListItemText primary="Genera & Stampa" />
                    </ListItem>
                  </List>
                </Collapse>

              </List>
          </Menu>

          <Typography variant="h3" component="div" sx={{ flexGrow: 1 }}>
            <b>SoftSolutions</b>
          </Typography>

          {/* Right hand side */}

              <IconButton
                size="large"
                aria-label="account of current user"
                aria-controls="menu-appbar"
                aria-haspopup="true"
                onClick={clickRightMenu}
                color="inherit"
              >
                <AccountCircle />
              </IconButton>
              
              <Menu
                id="menu-appbar"
                anchorEl={anchorEl}
                anchorOrigin={{
                  vertical: 'top',
                  horizontal: 'right',
                }}
                keepMounted
                transformOrigin={{
                  vertical: 'top',
                  horizontal: 'right',
                }}
                open={Boolean(anchorEl)}
                onClose={handleClose}
              >
                <ListItem button onClick={() => redirectRoute("/profile")}>
                  <ListItemText primary="Profile" />
                </ListItem>
                <ListItem button onClick={() => redirectRoute("/myaccount")}>
                  <ListItemText primary="My Account" />
                </ListItem>                
                <ListItem button onClick={() => redirectRoute("/login")}>
                  <ListItemText primary="Login" />
                </ListItem>
                <ListItem button onClick={() => redirectRoute("/logout")}>
                  <ListItemText primary="Logout" />
                </ListItem>
                <ListItem button onClick={() => redirectRoute("/register")}>
                  <ListItemText primary="Register" />
                </ListItem>
              </Menu>
        </Toolbar>
      </AppBar>
    </Box>
  );
}
