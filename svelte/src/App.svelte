<script>
	
</script>

<main>
	<h1>Titolo</h1>
	<nav>
		<a href="javascript:window.open('https://www.google.com')" id="google" class="barra" title="Google">Google</a>
		<a href="javascript:window.open('https://www.amazon.it')" id="amazon" class="barra" title="Amazon">Amazon</a>
		<a href="javascript:window.open('https://www.spotify.com')" id="spotify" class="barra" title="Spotify">Spotify</a>
		<a href="javascript:window.open('https://www.netflix.com')" id="netflix" class="barra" title="Netflix">Netflix</a>
		<a href="javascript:window.open('https://www.poste.it')" id="poste" class="barra" title="Poste Italiane">Poste Italiane</a>
	</nav>
</main>

<style>
	main{
		background: linear-gradient(to left, gray, black);
	}
	h1{
		font-size: 62px;
		margin-top: auto;
		text-align: center;
		font-weight: bold;
		font-family: 'Times New Roman', Times, serif;
		animation: colorchange 10s infinite;
	}
	@keyframes colorchange{
	0% { color: rgb(183, 0, 255); }
  	50% { color: rgb(0, 0, 255); }
 	100% { color: rgb(183, 0, 255); }
	}
	a{
		text-decoration:none;
	}
	nav{
		font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
		font-size: 28px;
		text-align: center;
		background-repeat: no-repeat;
		background-attachment: fixed;
	}
	#google{
		color: rgb(255, 102, 0);
	}
	#amazon{
		color: rgb(0, 238, 255);
	}
	#spotify{
		color: rgb(2, 182, 2);
	}
	#netflix{
		color: red;
	}
	#poste{
		color: yellow;
	}
	.barra{
		margin-right: 50px;
	}
</style>