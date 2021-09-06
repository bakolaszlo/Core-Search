<template>
  <div class="top">
    <div class="logo">
      <router-link to="/">
        <img
          class="google-logo"
          src="../assets/vuegle.png"
          style="width: 128px; height: 50px;"
        />
      </router-link>
    </div>

    <div class="searchBar">
      <div class="searchInput">
        <div class="searchIconHolder">
          <span class="searchIcon">
            <svg
              focusable="false"
              xmlns="http://www.w3.org/2000/svg"
              viewBox="0 0 28 28"
            >
              <path
                d="M15.5 14h-.79l-.28-.27A6.471 6.471 0 0 0 16 9.5 6.5 6.5 0 1 0 9.5 16c1.61 0 3.09-.59 4.23-1.57l.27.28v.79l5 4.99L20.49 19l-4.99-5zm-6 0C7.01 14 5 11.99 5 9.5S7.01 5 9.5 5 14 7.01 14 9.5 11.99 14 9.5 14z"
              />
            </svg>
          </span>
        </div>
        <div class="text_area">
          <div class="asd"></div>
          <input
            class="srch"
            type="text"
            v-model="searchText"
            v-on:keyup.enter="submitSearch"
          />
        </div>
      </div>
    </div>
  </div>
  <hr />
  <div class="article_holder">
    <h2 v-if="!articles">No results found.</h2>
    <div class="article" v-for="article in articles" :key="article.id">
      <div class="article-preview">
        <a :href="article.link">
          <img
            :src="getPreview(article)"
            style="width: 150px; height: 200px; border: none;"
          />
        </a>
      </div>
      <div class="right">
        <div class="article-title">
          {{ article.title }}
        </div>
        <div class="article-authors">
          By:
          <a href="" v-for="(author, index) in article.authors" :key="index"
            >{{ author
            }}<span v-if="index < article.authors.length - 1">, </span></a
          >
        </div>
        <div class="article-description" v-if="article.description">
          {{ article.description.substring(0, 400) + ".." }}
        </div>
        <div class="download-pdf">
          <a
            v-if="article.link"
            class="get-pdf"
            :href="article.link"
            target="_blank"
            >Get PDF</a
          >
          <a v-else class="get-pdf">No link available</a>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import $ from "jquery";
export default {
  data() {
    return {
      searchText: this.$route.params.searchText,
      articles: {},
    };
  },
  methods: {
    getPreview(article) {
      return "https://core.ac.uk/image/" + article.id + "/medium";
    },
    submitSearch() {
      if (this.searchText) {
        this.$router.replace(`/search/${this.searchText}`);
        var settings = {
          url: "/article/" + this.searchText,
          method: "GET",
          timeout: 0,
        };

        $.ajax(settings).done((response) => {
          console.log(response);
          this.articles = response;
        });
      }
    },
  },
  mounted() {
    var settings = {
      url: "/article/" + this.searchText,
      method: "GET",
      timeout: 0,
    };

    $.ajax(settings).done((response) => {
      console.log(response);
      this.articles = response;
    });
  },
};
</script>

<style scoped lang="scss">
$fa-font-path: "~@fortawesome/fontawesome-free/webfonts";
@import "~@fortawesome/fontawesome-free/scss/fontawesome";
@import "~@fortawesome/fontawesome-free/scss/solid";
@import "~@fortawesome/fontawesome-free/scss/regular";
@import "~@fortawesome/fontawesome-free/scss/brands";

* {
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
}
.article {
  display: flex;
  flex-direction: row;
  margin: 2rem 4rem;
  padding: 1rem;
  background-color: #f2f2f2;
  border-top: 6px solid #2a9d8f;
  border-bottom-left-radius: 20px;
  border-bottom-right-radius: 20px;
  transition: 0.2s ease-in-out;
}

.article-title {
  display: flex;
  flex-wrap: wrap;
  margin: 1rem;
  text-align: left;
  font-weight: bold;
  font-size: 1.7rem;
}

.article-authors {
  text-align: left;
  margin: 1rem;
  font-weight: bold;
}

.article-authors a {
  font-weight: 400;
  text-decoration: none;
}

.article-authors a:hover {
  text-decoration: underline;
}

.article-preview {
  display: flex;
  margin: auto 10px;
}

.article-preview img {
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
  background-color: #fff;
}

.article-description {
  text-align: left;
  margin: 1rem;
}

.download-pdf {
  display: flex;
}

.get-pdf {
  text-decoration: none;
  color: #fff;
  padding: 12px 32px;
  background-color: #e76f51;
  border-radius: 16px;
  margin: 1rem;
  font-weight: 500;
  transition: 0.2s ease-in-out;
}

.get-pdf:hover {
  background-color: #f4a261;
}

.article:hover {
  border-top-color: #264653;
  background-color: #fff;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.25);
}

@media (max-width: 650px) {
  .article-preview {
    display: none;
  }
}

.searchBar {
  width: 100%;
  max-width: 584px;
  border: 1px solid #dfe1e5;
  box-shadow: none;
  border-radius: 24px;
  margin: 20px auto 20px auto;
  padding: 3px;
}

.logo {
  margin: 20px 30px auto 30px;
}

.searchBar:hover {
  box-shadow: 0 0 1px 2px rgba(0, 0, 0, 0.08);
  border: 1px solid transparent;
}

.searchInput {
  flex: 1;
  display: flex;
  padding: 5px 8px 0 16px;
  padding-left: 14px;
  margin: 0 auto;
}

.searchIconHolder {
  display: flex;
  align-items: center;
  padding-right: 13px;
  margin-top: -5px;
  margin: 0 auto;
}

.searchIcon {
  margin-top: 3px;
  color: #9aa0a6;
  height: 20px;
  width: 20px;
  display: inline-block;
  fill: currentColor;
  height: 24px;
  line-height: 24px;
  position: relative;
  width: 24px;
}

.text_area {
  display: flex;
  flex: 1;
  flex-wrap: wrap;
}

.asd {
  color: transparent;
  flex: 100%;
  white-space: pre;
  height: 34px;
}

.srch {
  background-color: transparent;
  border: none;
  margin: 0;
  color: rgba(0, 0, 0, 0.87);
  word-wrap: break-word;
  outline: none;
  display: flex;
  flex: 100%;
  -webkit-tap-highlight-color: transparent;
  margin-top: -37px;
  height: 34px;
  font-size: 16px;
  vertical-align: middle;
}

hr {
  margin: 0 0 2rem 0;
  color: #adb5bd;
  background-color: gray;
  opacity: 0.3;
}

.searchInput {
  flex: 1;
  display: flex;
  padding: 5px 8px 0 16px;
  padding-left: 14px;
  margin: 0 auto;
}

.top {
  display: flex;
}
</style>
