<template>
  <div class="search">
    <form action="https://google.com/search" method="GET">
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
              maxlength="2048"
              name="q"
              type="text"
              autofocus
              title="Search"
              value=""
              spellcheck="false"
              autocapitalize="off"
              aria-autocomplete="both"
              autocomplete="off"
              aria-label="Search"
              aria-haspopup="false"
            />
          </div>
          <div class="dRYYxd">
            <div
              class="voiceIcon-holder"
              aria-label="Search by voice"
              role="button"
              tabindex="0"
            >
              <svg
                class="voiceIcon"
                focusable="false"
                viewBox="0 0 24 24"
                xmlns="http://www.w3.org/2000/svg"
              >
                <path
                  fill="#4285f4"
                  d="m12 15c1.66 0 3-1.31 3-2.97v-7.02c0-1.66-1.34-3.01-3-3.01s-3 1.34-3 3.01v7.02c0 1.66 1.34 2.97 3 2.97z"
                ></path>
                <path fill="#34a853" d="m11 18.08h2v3.92h-2z"></path>
                <path
                  fill="#fbbc05"
                  d="m7.05 16.87c-1.27-1.33-2.05-2.83-2.05-4.87h2c0 1.45 0.56 2.42 1.47 3.38v0.32l-1.15 1.18z"
                ></path>
                <path
                  fill="#ea4335"
                  d="m12 16.93a4.97 5.25 0 0 1 -3.54 -1.55l-1.41 1.49c1.26 1.34 3.02 2.13 4.95 2.13 3.87 0 6.99-2.92 6.99-7h-1.99c0 2.92-2.24 4.93-5 4.93z"
                ></path>
              </svg>
            </div>
          </div>
        </div>
      </div>
      <input type="submit" value="Google Search" class="search_btn" />
      <input type="submit" value="I'm Feeling Lucky" class="lucky_btn" />
    </form>
  </div>
</template>

<script>
export default {
  name: "Search",
};
</script>

<style scoped>
.search {
  flex-shrink: 0;
  box-sizing: border-box;
  max-height: 160px;
  padding: 20px;
  text-align: center;
  align-self: center;
  max-width: 100%;
  width: 616px;
  display: flex;
  flex-direction: column;
  margin-top: 6px;
}

#search {
  border-radius: 24px;
  background-color: #fff;
  border: 1px solid #dfe1e5;
  box-shadow: none;
  height: 44px;
  width: 584px;
  margin: 0 auto;
  margin-top: 30px;
  margin-bottom: 20px;
  padding-left: 20px;
}

.searchBar {
  width: 100%;
  max-width: 584px;
  border: 1px solid #dfe1e5;
  box-shadow: none;
  border-radius: 24px;
  margin-bottom: 18px;
  padding: 3px;
}

.searchBar:hover {
  box-shadow: 0 0 1px 2px rgba(0, 0, 0, 0.08);
  border: 1px solid transparent;
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

.searchInput {
  flex: 1;
  display: flex;
  padding: 5px 8px 0 16px;
  padding-left: 14px;
  margin: 0 auto;
}

.search_btn {
  background-color: #f8f9fa;
  border: 1px solid #f8f9fa;
  border-radius: 4px;
  color: #3c4043;
  font-family: arial, sans-serif;
  font-size: 14px;
  margin: 11px 4px;
  padding: 0 16px;
  line-height: 27px;
  height: 36px;
  min-width: 54px;
  text-align: center;
  cursor: pointer;
  user-select: none;
}

.search_btn:hover {
  border: 1px solid #c6c6c6;
  box-shadow: 0 1px 1px rgba(0, 0, 0, 0.1);
  color: #222;
  background-image: -webkit-linear-gradient(top, #f8f8f8, #f1f1f1);
  background-color: #f8f8f8;
}

.lucky_btn {
  background-color: #f8f9fa;
  border: 1px solid #f8f9fa;
  border-radius: 4px;
  color: #3c4043;
  font-family: arial, sans-serif;
  font-size: 14px;
  margin: 11px 4px;
  padding: 0 16px;
  line-height: 27px;
  height: 36px;
  min-width: 54px;
  text-align: center;
  cursor: pointer;
  user-select: none;
}

.lucky_btn:hover {
  border: 1px solid #c6c6c6;
  box-shadow: 0 1px 1px rgba(0, 0, 0, 0.1);
  color: #222;
  background-image: -webkit-linear-gradient(top, #f8f8f8, #f1f1f1);
  background-color: #f8f8f8;
}

.voiceIcon-holder {
  flex: 1 0 auto;
  display: flex;
  cursor: pointer;
  align-items: center;
  border: 0;
  background: transparent;
  outline: none;
  padding: 0 8px;
  width: 24px;
  line-height: 44px;
}
.dRYYxd {
  display: flex;
  flex: 0 0 auto;
  margin-top: -5px;
  align-items: stretch;
  flex-direction: row;
}

.minidiv .dRYYxd {
  margin-top: 0;
}

.voiceIcon {
  height: 24px;
  width: 24px;
  vertical-align: middle;
}

.minidiv .voiceIcon-holder {
  line-height: 32px;
}

.minidiv .voiceIcon {
  width: 20px;
  height: 20px;
}
</style>
