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
                <hr />

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Anagrafiche" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
                <ListItem button onClick={() => redirectRoute("/Anagrafica/Altro")}>
                      <ListItemText primary="Altro" />
                    </ListItem>     
                  </List>
                </Collapse>

                <hr />
                <ListItem button  onClick={() => redirectRoute("/Anagrafica")}>
                  <ListItemText primary="Anagrafica" />
                </ListItem>
                <hr />

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Ordini fornitori" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/OrdiniFornitori/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Ordini clienti" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("OrdiniClienti/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Lotti" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("Lotti/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Movimenti di magazzino" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/MovimentiMagazzino/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Documenti di trasporto" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/DocumentiTrasporto/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Report Generali" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/ReportGenerali/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Conto lavorazione a fornitore" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/ContoFornitore/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Conto lavorazione da cliente" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/ContoCliente/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Prodotti & Formule" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/ProdottiFormule/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Listino clienti" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/ListinoClienti/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Inventario" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/Inventario/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Abilitazioni" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/Abilitazioni/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Tabelle di sevizio" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/TabServizio/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Tabelle risevate" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/TabRiservate/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
                  </List>
                </Collapse>

                <hr />
                <ListItem button  onClick={() => redirectRoute("/Azienda")}>
                  <ListItemText primary="Azienda" />
                </ListItem>
                <hr />

                <ListItem button  onClick={() => redirectRoute("/Attivita")}>
                  <ListItemText primary="Attività" />
                </ListItem>
                <hr />

                <ListItem button  onClick={() => redirectRoute("/Operatori")}>
                  <ListItemText primary="Operatori" />
                </ListItem>
                <hr />

                <ListItem button onClick={clickFeatures}>
                  <ListItemText primary="Magazzino fiscale" />
                  {openNested ? <ExpandLess /> : <ExpandMore />}
                </ListItem>
                <Collapse in={openNested} timeout="auto" unmountOnExit>
                  <List component="div" disablePadding>
             {/*   <ListItem button onClick={() => redirectRoute("/MagazzinoFiscale/Feature1")}>
                      <ListItemText primary="Feature1" />
                    </ListItem>     */}
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
