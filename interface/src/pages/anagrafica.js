import * as React from 'react';
import { styled } from '@mui/material/styles';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import InputBase from '@mui/material/InputBase';
import MenuIcon from '@mui/icons-material/Menu';
import Stack from '@mui/material/Stack';
import TextField from '@mui/material/TextField';
import Radio from '@mui/material/Radio';
import RadioGroup from '@mui/material/RadioGroup';
import FormControlLabel from '@mui/material/FormControlLabel';
import FormControl from '@mui/material/FormControl';
import FormLabel from '@mui/material/FormLabel';
import Button from '@mui/material/Button';

export default function Anagrafica() {

  const [coge, setCoge] = React.useState('');
  const [email, setEmail] = React.useState('');
  const [Rsociale, setRsociale] = React.useState('');
  const [indirizzo, setIndirizzo] = React.useState('');
  const [nCivico, setNcivico] = React.useState('');
  const [interno, setInterno] = React.useState('');
  const [CAP, setCAP] = React.useState(''); 
  const [local, setLocal] = React.useState('');
  const [provincia, setProvincia] = React.useState(''); 
  const [fineValidita, setFine] = React.useState('');

  const changeRsociale = (event) => {
    setRsociale(event.target.value);
  };
  const changeEmail = (event) => {
    setEmail(event.target.value);
  };
  const changeCoge = (event) => {
    setCoge(event.target.value);
  };
  const changeIndirizzo = (event) => {
    setIndirizzo(event.target.value);
  };
  const changeNcivico = (event) => {
    setNcivico(event.target.value);
  };
  const changeInterno = (event) => {
    setInterno(event.target.value);
  };
  const changeCAP = (event) => {
    setCAP(event.target.value);
  };
  const changeLocal = (event) => {
    setLocal(event.target.value);
  };
  const changeProvincia = (event) => {
    setProvincia(event.target.value);
  };
  const changeFine = (event) => {
    setFine(event.target.value);
  };
    
  return (
  <div align="left" class="anagrafica">
    
    <div align="center">
        <h1>
          Registazione
        </h1>
      </div>

    <Box sx={{ flexGrow: 1 }}>
      <div align="left">
        <Stack direction="row" spacing={12}>
          <TextField
            required
            id="outlined-required"
            label="Regione Sociale"
            value={Rsociale}
            onChange={changeRsociale}
          />
          <FormControl >
            <FormLabel id="demo-radio-buttons-group-label">Contratto</FormLabel>
            <RadioGroup
              row
              aria-labelledby="demo-radio-buttons-group-label"
              name="radio-buttons-group"
            >
              <FormControlLabel value="si" control={<Radio />} label="Si" />
              <FormControlLabel value="no" control={<Radio />} label="No" />
            </RadioGroup>
          </FormControl>
          <FormControl >
            <FormLabel id="demo-radio-buttons-group-label">Black List</FormLabel>
            <RadioGroup
              row
              aria-labelledby="demo-radio-buttons-group-label"
              name="radio-buttons-group"
            >
              <FormControlLabel value="si" control={<Radio />} label="Si" />
              <FormControlLabel value="no" control={<Radio />} label="No" />
            </RadioGroup>
          </FormControl>
        </Stack>
          <br />
          <TextField
            required
            id="outlined-required"
            label="Indirizzo e-mail"
            value={email}
            onChange={changeEmail}
          />
          <br /><br />
          <TextField
            required
            id="outlined-required"
            label="Codice Coge"
            value={coge}
            onChange={changeCoge}
          />
          <br /><br />
          <TextField
            required
            id="outlined-required"
            label="Indirizzo"
            value={indirizzo}
            onChange={changeIndirizzo}
          />
          <br /><br />
          <Stack direction="row" spacing={5}>
            <TextField
              required
              id="outlined-required"
              label="Numero civico"
              value={nCivico}
              onChange={changeNcivico}
            />
            
            <TextField
              required
              id="outlined-required"
              label="Interno"
              value={interno}
              onChange={changeInterno}
              sx={{width: '90px' }}
            />
            <TextField
              required
              id="outlined-required"
              label="CAP"
              value={CAP}
              onChange={changeCAP}
              sx={{width: '90px' }}
            /><ht /><ht /><ht /><ht /><ht />
            <Stack>
              <Button variant="contained" color="primary">Nuova azienda</Button>
            </Stack>
          </Stack>
          <br />
          <Stack direction="row" spacing={62.5}>
          <TextField
              required
              id="outlined-required"
              label="Località"
              value={local}
              onChange={changeLocal}
            />
            <Stack>
              <Button variant="contained" color="warning">Modifica azienda</Button>
            </Stack>
          </Stack>
          <br />
        <Stack direction="row" spacing={19.5}>
          <TextField
              required
              id="outlined-required"
              label="Provincia"
              value={provincia}
              onChange={changeProvincia}
              sx={{width: '120px' }}
            />

          <FormControl >
            <FormLabel id="demo-radio-buttons-group-label">Tipo Azienda</FormLabel>
            <RadioGroup
              row
              aria-labelledby="demo-radio-buttons-group-label"
              name="radio-buttons-group"
            >
              <FormControlLabel value="cliente" control={<Radio />} label="Cliente" />
              <FormControlLabel value="fornitore" control={<Radio />} label="Fornitore" />
              <FormControlLabel value="altro" control={<Radio />} label="Altro" />
            </RadioGroup>
          </FormControl>
          <Stack>
              <Button variant="contained" color="error">Rimuovi azienda</Button>
            </Stack>
        </Stack>
          <br />
          <Stack direction="row" spacing={62.5}>
            <TextField
                required
                id="outlined-required"
                label="Data fine validità"
                value={fineValidita}
                onChange={changeFine}
              />
            <Stack>
              <Button variant="contained" color="primary">Aggiorna</Button>
            </Stack>
          </Stack>
          <br />
          <Stack direction="row" spacing={64.5}>
            <TextField
            id="outlined-multiline-static"
            label="Note"
            multiline
            rows={4}
          />
            <Stack>
              <Button variant="contained" color="primary">Annulla</Button>
            </Stack>
          </Stack>
      </div>
    </Box>
  </div>
  );
}