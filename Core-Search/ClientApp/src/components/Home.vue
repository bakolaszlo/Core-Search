<template>
  <div class="main">
    <Header />
    <GoogleLogo />
    <SearchBar />
    <Alts />
    <Footer />
  </div>
</template>

<script>
import Header from "./Header.vue";
import GoogleLogo from "./Logo.vue";
import SearchBar from "./SearchBar.vue";
import Alts from "./Alts.vue";
import Footer from "./Footer.vue";

export default {
  name: "Home",
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
