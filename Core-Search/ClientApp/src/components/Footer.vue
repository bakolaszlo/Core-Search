<template>
  <div class="footer">
    <div class="country">
      Romania
    </div>
    <div class="footer_list">
      <div class="footer_left">
        <a
          class="footer_link"
          href="https://about.google/?utm_source=google-RO&amp;utm_medium=referral&amp;utm_campaign=hp-footer&amp;fg=1"
        >
          About
        </a>
        <a
          class="footer_link"
          href="https://www.google.com/intl/en_ro/ads/?subid=ww-ww-et-g-awa-a-g_hpafoot1_1!o2&amp;utm_source=google.com&amp;utm_medium=referral&amp;utm_campaign=google_hpafooter&amp;fg=1"
        >
          Advertising
        </a>
        <a
          class="footer_link"
          href="https://www.google.com/services/?subid=ww-ww-et-g-awa-a-g_hpbfoot1_1!o2&amp;utm_source=google.com&amp;utm_medium=referral&amp;utm_campaign=google_hpbfooter&amp;fg=1"
        >
          Business
        </a>
        <a
          class="footer_link"
          href="https://google.com/search/howsearchworks/?fg=1"
        >
          How Search works
        </a>
      </div>
      <div class="footer_right">
        <a
          class="footer_link"
          href="https://policies.google.com/privacy?hl=en-RO&amp;fg=1"
        >
          Privacy
        </a>
        <a
          class="footer_link"
          href="https://policies.google.com/terms?hl=en-RO&amp;fg=1"
        >
          Terms
        </a>
        <a class="footer_link" href="#">
          Settings
        </a>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Footer",
};
</script>

<style scoped>
.country {
  padding: 15px 30px;
  border-bottom: 1px solid #dadce0;
  font-size: 15px;
  color: rgba(0, 0, 0, 0.54);
  font-family: arial, sans-serif;
}

.footer {
  background: #f2f2f2;
  flex-shrink: 0;
  box-sizing: border-box;
  margin-top: auto;
  display: flex;
  flex-direction: column;
  align-content: flex-end;
}

.footer_list {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  padding: 0 20px;
}

@media only screen and (max-width: 664px) {
  .footer_list {
    display: flex;
    flex-wrap: wrap;
    justify-content: center;
    padding: 0 20px;
  }
}

a {
  text-decoration: none;
}

a:hover {
  text-decoration: underline;
}

.footer_left {
  display: flex;
  flex-wrap: wrap;
  text-align: center;
  justify-content: center;
}

.footer_right {
  display: flex;
  flex-wrap: wrap;
  text-align: center;
  justify-content: center;
}

.footer_link {
  display: block;
  padding: 15px;
  white-space: nowrap;
  font-size: 14px;
}

a.footer_link {
  color: #70757a;
}
</style>
