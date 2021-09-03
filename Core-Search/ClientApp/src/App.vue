<template>
    <div class="main">
        <Header />
        <GoogleLogo />
        <SearchBar />
        <Alts />
        <Footer />
    </div>
    <router-view />
</template>

<script>
    import Header from "./components/Header.vue";
    import GoogleLogo from "./components/Logo.vue";
    import SearchBar from "./components/SearchBar.vue";
    import Alts from "./components/Alts.vue";
    import Footer from "./components/Footer.vue";

    export default {
        name: "App",
        components: {
            Header,
            GoogleLogo,
            SearchBar,
            Alts,
            Footer,
        },
    };
</script>

<style>
    .main {
        display: flex;
        flex-direction: column;
        height: 100%;
    }

    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        display: flex;
        flex-direction: column;
        height: 100%;
    }
</style>
