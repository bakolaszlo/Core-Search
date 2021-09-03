<template>
  <div class="logo">
    <img
      class="google-logo"
      src="https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png"
    />
  </div>
</template>

<script>
export default {
  name: "GoogleLogo",
};
</script>

<style scoped>
.logo {
  display: flex;
  flex-direction: column;
  align-items: center;
  min-height: 92px;
  max-height: 290px;
  height: calc(100% - 560px);
  flex-shrink: 0;
  box-sizing: border-box;
  justify-content: flex-end;
  margin-top: 6px;
}
</style>
