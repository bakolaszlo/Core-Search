<template>
  <div class="alts">
    Google offered in:
    <a
      href="https://www.google.com/setprefs?sig=0_MGvm-VyiMxwQqFKOFEOyR1VUjec%3D&amp;hl=ro&amp;source=homepage&amp;sa=X&amp;ved=0ahUKEwjkz4ehx5LyAhUZQUEAHUiNAM8Q2ZgBCA4"
    >
      Română
    </a>
    <a
      href="https://www.google.com/setprefs?sig=0_MGvm-VyiMxwQqFKOFEOyR1VUjec%3D&amp;hl=hu&amp;source=homepage&amp;sa=X&amp;ved=0ahUKEwjkz4ehx5LyAhUZQUEAHUiNAM8Q2ZgBCA8"
    >
      Magyar
    </a>
    <a
      href="https://www.google.com/setprefs?sig=0_MGvm-VyiMxwQqFKOFEOyR1VUjec%3D&amp;hl=de&amp;source=homepage&amp;sa=X&amp;ved=0ahUKEwjkz4ehx5LyAhUZQUEAHUiNAM8Q2ZgBCBA"
    >
      Deutsch
    </a>
  </div>
</template>

<script>
export default {
  name: "Alts",
};
</script>

<style scoped>
.alts {
  color: #3c4043;
  font-size: 13px;
  display: flex;
  line-height: 28px;
  font-family: arial, sans-serif;
  flex-shrink: 0;
  box-sizing: border-box;
  flex-grow: 1;
  justify-content: center;
  margin-bottom: 24px;
}

.alts a {
  color: #1a0dab;
  padding: 0 3px;
  text-decoration: none;
}

.alts a:hover {
  text-decoration: underline;
}

@media only screen and (max-width: 320px) {
  .alts {
    margin-top: 5rem;
  }
}
</style>
